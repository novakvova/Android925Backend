using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.ApiBackend.Data.Identity
{
    public class AppUser : IdentityUser
    {
        public virtual ICollection<AppUserRole> UserRoles { get; set; }
    }
}
