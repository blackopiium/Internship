using System;
using System.Collections.Generic;
using System.Text;

namespace Furn_Store.Business.DTO
{
    public class ItemDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public float Price { get; set; }
        public int FactoryId { get; set; }
        public int Charachteristics_Item_Id { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }

    }
}
