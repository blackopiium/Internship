using Furn_Store.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Furn_Store.Data.Models
{
    [Table("Order_Items")]
    public class Order_Items : IEntity<int>
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ItemId { get; set; }
        public int Count_of_items { get; set; }
        public Item Item { get; set; }
        public Order Order { get; set; }
    }
}
