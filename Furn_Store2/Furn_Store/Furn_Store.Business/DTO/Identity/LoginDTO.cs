using System;
using System.Collections.Generic;
using System.Text;

namespace Furn_Store.Business.DTO.Identity
{
    public class LoginDTO
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
