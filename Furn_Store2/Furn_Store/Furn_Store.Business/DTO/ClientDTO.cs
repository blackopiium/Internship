using System;
using System.Collections.Generic;
using System.Text;

namespace Furn_Store.Business.DTO
{
    public class ClientDTO
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public int OrderId { get; set; }
        public string Phone_Number { get; set; }
        public string Email { get; set; }
    }
}
