using System.Security.Claims;
using Agriculturapp.Models;
namespace Agriculturapp.Authentication
{
    public partial class ApplicationPrincipalFactory
    {
         partial void OnCreatePrincipal(ClaimsPrincipal principal, ApplicationUser user)
         {
             var identity = principal.Identity as ClaimsIdentity;

             if (!string.IsNullOrEmpty(user.DetalleMetodopagoId.ToString()))
             {

                 // the property will be available at the client-side.
                 identity.AddClaim(new Claim("DetalleMetodopagoId", user.DetalleMetodopagoId.ToString()));
                identity.AddClaim(new Claim("Tipouser", user.Tipouser.ToString()));
                identity.AddClaim(new Claim("Apellido", user.Apellido.ToString()));       
                 identity.AddClaim(new Claim("Nombre", user.Nombre.ToString()));       
                identity.AddClaim(new Claim("NroCuenta", user.NroCuenta.ToString()));       
                identity.AddClaim(new Claim("Identification", user.Identification.ToString()));       
                  

             }

            else if(!user.EmailConfirmed==false){
                identity.AddClaim(new Claim("EmailConfirmed", user.EmailConfirmed.ToString()));

            }
         }
        
    }
}