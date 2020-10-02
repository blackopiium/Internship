using System;
using System.Collections.Generic;
using System.Text;

namespace Furn_Store.Business.DTO
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public float Price { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int Apartment { get; set; }
    }
}
