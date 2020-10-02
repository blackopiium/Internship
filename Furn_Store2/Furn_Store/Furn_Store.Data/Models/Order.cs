using Furn_Store.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Furn_Store.Data.Models
{
    [Table("Order")]
    public class Order : IEntity<int>
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public float Price { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int Apartment { get; set; }
        public List<Order_Items> Order_Items { get; set; }
        public Client Client { get; set; }
    }
}
