using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMART.Models
{
    public class SubCategory:Category
    {
        
        public int Sub_id { get; set; }
        public string sub_Name { get; set; }
        public string desc { get; set; }
        public int Gst { get; set; }
    }
}
