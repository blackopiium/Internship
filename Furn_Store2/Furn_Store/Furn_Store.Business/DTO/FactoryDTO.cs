using System;
using System.Collections.Generic;
using System.Text;

namespace Furn_Store.Business.DTO
{
    public class FactoryDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
    }
}
