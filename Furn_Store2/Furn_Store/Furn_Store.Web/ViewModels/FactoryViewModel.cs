using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Furn_Store.Web.ViewModels
{
    public class FactoryViewModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public string description { get; set; }
        public string imagePath { get; set; }
    }
}
