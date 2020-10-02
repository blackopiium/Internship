using System;
using System.Collections.Generic;
using System.Text;

namespace Furn_Store.Business.DTO.Identity
{
    public class RegisterDTO
    {
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
    }
}
