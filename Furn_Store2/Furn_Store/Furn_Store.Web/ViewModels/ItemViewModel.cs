using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Furn_Store.Web.ViewModels
{
    public class ItemViewModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int categoryId { get; set; }
        public float price { get; set; }
        public int factoryId { get; set; }
        public string imagePath { get; set; }
        public int charachteristics_Item_Id { get; set; }
    }
}
