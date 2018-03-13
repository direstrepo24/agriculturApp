using System;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;

namespace Agriculturapp.Authentication
{
    public class TokenProviderOptions
    {
        public static string Audience { get; } = "AgriculturappAudience";
        public static string Issuer { get; } = "Agriculturapp";
        public static SymmetricSecurityKey Key { get; } = new SymmetricSecurityKey(Encoding.ASCII.GetBytes("AgriculturappSecretSecurityKeyAgriculturapp"));
        public static TimeSpan Expiration { get; } = TimeSpan.FromMinutes(50);
        public static SigningCredentials SigningCredentials { get; } = new SigningCredentials(Key, SecurityAlgorithms.HmacSha256);
    }
}
