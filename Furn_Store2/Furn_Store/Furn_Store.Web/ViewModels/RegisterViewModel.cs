using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Furn_Store.Web.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Email is required!")]
        public string email { get; set; }
        [Required(ErrorMessage = "Username is required!")]
        public string userName { get; set; }
        [Required(ErrorMessage = "Password is required!")]
        public string password { get; set; }
        [Required(ErrorMessage = "Confirmed password is required!")]
        [Compare("Password", ErrorMessage = "Passwords aren't equal!")]
        public string passwordConfirm { get; set; }
    }
}
