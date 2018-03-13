using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Agriculturapp.Models
{
    public partial class ApplicationUser : IdentityUser
    {
        [NotMapped]
        public IEnumerable<string> RoleNames { get; set; }

        [IgnoreDataMember]
        public override string PasswordHash { get; set; }
    }
}

