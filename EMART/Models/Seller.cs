using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace EMART.Models
{
    public class Seller
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "Please Enter Name")]
        [DisplayName("Seller Name")]
        [StringLength(maximumLength: 20, MinimumLength = 4, ErrorMessage = "Please Enter Valid Name")]
        public string username { get; set; }
        [DataType("Password")]
        [DisplayName("Password")]
        [Required(ErrorMessage = "Please Enter Valid Password")]
        [RegularExpression("[a-z0-9]{6,8}", ErrorMessage = "use 6 to 8 letters")]
        public string password { get; set; }
        [Required(ErrorMessage = "Please Enter CompanyName")]
        public string companyname { get; set; }
        [Required(ErrorMessage = "Please Enter Gstin")]
        public string GSTIN { get; set; }
        [Required(ErrorMessage = "Please Enter Description")]
        public string Desc { get; set; }
        [Required(ErrorMessage = "Please Enter Address")]
        public string address { get; set; }
        [Required(ErrorMessage = "Please Enter Mail")]
        [EmailAddress(ErrorMessage = "Please Enter Valid ")]
        public string emailid { get; set; }
        [RegularExpression(@"[6-9]\d{9}", ErrorMessage = "Please Enter Valid Mobile no")]
        public int contact { get; set; }
    }
}
