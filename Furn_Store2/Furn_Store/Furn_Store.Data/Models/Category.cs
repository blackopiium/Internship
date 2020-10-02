using Furn_Store.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Furn_Store.Data.Models
{
    [Table("Category")]
    public class Category : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public List<Item> Items { get; set; }
    }
}
