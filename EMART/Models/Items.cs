using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EMART.Models
{
    public class Items:Category
    {
        [Key]
        public int id { get; set; }
       
        public int price { get; set; }
        public string item_name { get; set; }
        public string description { get; set; }
        public int stock_number { get; set; }
        public string remarks { get; set; }
    }
}
