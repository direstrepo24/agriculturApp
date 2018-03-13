using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Agriculturapp.Models
{
    public partial class ApplicationUser
    {
        public long  DetalleMetodopagoId { get; set; }
        public int Tipouser{get;set;}
        public string Apellido{get;set;}
        public string Nombre{get;set;}
        public string NroCuenta{get;set;}
        public string Identification{get;set;}


    }
}