using System;
using System.Collections.Generic;
using System.Text;

namespace Furn_Store.Business.DTO.Identity
{
   public class LoginToken
    {
        public bool success { get; set; }
        public string token { get; set; }
        public string error { get; set; }
    }
}
