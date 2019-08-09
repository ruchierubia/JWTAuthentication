using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAuthentication.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        public int Email { get; set; }

        [Required]
        public int Password { get; set; }
    }
}
