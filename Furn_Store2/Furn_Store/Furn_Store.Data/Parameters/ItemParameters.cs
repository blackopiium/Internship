using System;
using System.Collections.Generic;
using System.Text;

namespace Furn_Store.Data.Parameters
{
    public class ItemParameters : QueryStringParameters
    {
        public float MinPrice { get; set; } = 0;
        public float MaxPrice { get; set; } = float.MaxValue;
        public bool ValidPriceRange => MaxPrice >= MinPrice && MinPrice >= 0;
        public string Name { get; set; }
    }
}
