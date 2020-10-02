using Furn_Store.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Furn_Store.Data.Models
{
    [Table("Charachteristics_Item")]
    public class Charachteristics_Item : IEntity<int>
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int Width_it { get; set; }
        public int Height_it { get; set; }
        public int Length_it { get; set; }
        public string Colour_it { get; set; }
        public Item Item;
    }
}
