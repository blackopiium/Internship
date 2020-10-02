using Furn_Store.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Furn_Store.Data.Models
{
    [Table("Item")]
    public class Item : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public float Price { get; set; }
        public int FactoryId { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public int Charachteristics_Item_Id { get; set; }
        public Charachteristics_Item Charachteristics_Item { get; set; }
        public Category Category { get; set; }
        public Factory Factory { get; set; }
        public List<Order_Items> Order_Items { get; set; }

    }
}
