using System;
using System.Linq;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Linq;

using Agriculturapp.Authentication;
using Agriculturapp.Data;
using Agriculturapp.Models;

namespace Agriculturapp.Controllers
{
    [Route("/auth/[action]")]
    public partial class AuthController : Controller
    {
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IHostingEnvironment env;
        public AuthController(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager, IHostingEnvironment env)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.env = env;
        }

        private static T GetValue<T>(IDictionary<string, object> data, string key)
        {
            if (data.ContainsKey(key))
            {
                return (T)data[key];
            }

            if (data.ContainsKey(key.ToLower()))
            {
                return (T)data[key.ToLower()];
            }

            return default(T);
        }

        private IActionResult Error(string message)
        {
            return BadRequest(new { error = new { message } });
        }

        private IActionResult Jwt(IEnumerable<Claim> claims)
        {
            var handler = new JwtSecurityTokenHandler();

            var token = handler.CreateToken(new SecurityTokenDescriptor
            {
                Issuer = TokenProviderOptions.Issuer,
                Audience = TokenProviderOptions.Audience,
                SigningCredentials = TokenProviderOptions.SigningCredentials,
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.Add(TokenProviderOptions.Expiration)
            });

            return Json(new { access_token = handler.WriteToken(token), expires_in = TokenProviderOptions.Expiration.TotalSeconds });
        }

        [Authorize]
        [HttpPost("/auth/change-password")]
        public async Task<IActionResult> ChangePassword([FromBody]JObject data)
        {
            var oldPassword = data.GetValue("OldPassword", StringComparison.OrdinalIgnoreCase).ToObject<string>();
            var newPassword = data.GetValue("NewPassword", StringComparison.OrdinalIgnoreCase).ToObject<string>();

            var id = this.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            var user = await userManager.FindByIdAsync(id);

            var result = await userManager.ChangePasswordAsync(user, oldPassword, newPassword);

            if (!result.Succeeded)
            {
                var message = string.Join(", ", result.Errors.Select(error => error.Description));

                return Error(message);
            }

            return new NoContentResult();
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody]JObject data)
        {
            var username = data.GetValue("UserName", StringComparison.OrdinalIgnoreCase).ToObject<string>();
            var password = data.GetValue("Password", StringComparison.OrdinalIgnoreCase).ToObject<string>();

            if (username == null && password == null)
            {
                return Error("Invalid user name or password.");
            }

            if (env.EnvironmentName == "Development" && username == "admin" && password == "admin")
            {
                return Jwt(new List<Claim>() {
                  new Claim(ClaimTypes.Name, "admin"),
                  new Claim(ClaimTypes.Email, "admin")
                });
            }

            var user = await userManager.FindByNameAsync(username);

            if (user == null)
            {
                return Error("Invalid user name or password.");
            }

            var validPassword = await userManager.CheckPasswordAsync(user, password);

            if (!validPassword)
            {
                return Error("Invalid user name or password.");
            }

            var principal = await signInManager.CreateUserPrincipalAsync(user);

            return Jwt(principal.Claims);
        }

        partial void OnUserCreated(ApplicationUser user);

        [HttpPost]
        public async Task<IActionResult> Register([FromBody]JObject data)
        {
            var email = data.GetValue("Email", StringComparison.OrdinalIgnoreCase).ToObject<string>();
            var password = data.GetValue("Password", StringComparison.OrdinalIgnoreCase).ToObject<string>();

            var user = new ApplicationUser { UserName = email, Email = email };

            EntityPatch.Apply(user, data);

            OnUserCreated(user);

            var result = await userManager.CreateAsync(user, password);

            if (result.Succeeded)
            {
                return Created($"auth/Users('{user.Id}')", user);
            }
            else
            {
                return IdentityError(result);
            }
        }

        private IActionResult IdentityError(IdentityResult result)
        {
            var message = string.Join(", ", result.Errors.Select(error => error.Description));

            return BadRequest(new { error = new { message } });
        }
    }
}
