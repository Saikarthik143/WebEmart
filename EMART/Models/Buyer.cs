using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace EMART.Models
{
    public class Buyer
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please Enter Name")]
        [DisplayName("Buyer Name")]
        [StringLength(maximumLength: 20, MinimumLength = 4, ErrorMessage = "Please Enter Valid Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter Mail")]
        [EmailAddress(ErrorMessage = "Please Enter Valid ")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please Enter Name")]
        public string UserName { get; set; }
        [DataType("Password")]
        [DisplayName("Password")]
        [Required(ErrorMessage = "Please Enter Valid Password")]
        [RegularExpression("[a-z0-9]{6,8}", ErrorMessage = "use 6 to 8 letters")]
        public string Password { get; set; }
        [RegularExpression(@"[6-9]\d{9}", ErrorMessage = "Please Enter Valid Mobile no")]
        public string Mobile { get; set; }
        public DateTime date { get; set; }
        public Buyer()
        {

        }
    }
}
