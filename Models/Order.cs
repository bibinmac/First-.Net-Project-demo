using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BethanyPieShop.Models
{
    public class Order
    {
        [BindNever]        
        public int OrderId { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }

        [Required(ErrorMessage = "Please Enter your first name")]
        [Display(Name = "First Name")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please Enter your last name")]
        [Display(Name = "Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please Enter your Address ")]
        [Display(Name = "Address Line 1")]
        [StringLength(100)]
        public string AddressLine1 { get; set; }

        [Required(ErrorMessage = "Please Enter your Address ")]
        [Display(Name = "Address Line 2")]
        [StringLength(100)]

        public string AddressLine2 { get; set; }

        [Required(ErrorMessage = "Please Enter your Zip Code ")]
        [Display(Name = "Zip Code")]
        [StringLength(10,MinimumLength = 4)]

        public string ZipCode { get; set; }

        [Required(ErrorMessage = "Please Enter your City ")]
        [StringLength(10)]
        public string City { get; set; }

        [Required(ErrorMessage = "Please Enter your State ")]
        [StringLength(10)]

        public string State { get; set; }

        [Required(ErrorMessage = "Please Enter your Country ")]
        [StringLength(10)]
        public string Country { get; set; }

        [Required(ErrorMessage = "Please Enter your Phone Number ")]
        [StringLength(25)]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])",
            ErrorMessage = "The email address is not entered in a correct format")]

        public string Email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public decimal OrderTotal { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderPlaced { get; set; }




    }
}
