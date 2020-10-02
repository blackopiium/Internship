using Furn_Store.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Furn_Store.Data.Models
{
    [Table("Client")]
    public class Client : IEntity<int>
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public int OrderId { get; set; }
        public string Phone_Number { get; set; }
        public string Email { get; set; }
        public List<Order> Orders { get; set; }
    }
}
