using System;
using System.Collections.Generic;
using System.Text;

namespace Furn_Store.Business.DTO
{
    public class Charachteristic_Item_DTO
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int Width_it { get; set; }
        public int Height_it { get; set; }
        public int Length_it { get; set; }
        public string Colour_it { get; set; }
    }
}
