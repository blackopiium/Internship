using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Furn_Store.Web.ViewModels
{
    public class CategoryViewModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string imagePath { get; set; }
    }
}
