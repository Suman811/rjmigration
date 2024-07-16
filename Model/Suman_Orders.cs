using System.ComponentModel.DataAnnotations;

namespace rj.Model
{
    public class Suman_Orders
   
    {
        
        [Required(ErrorMessage = "id is required")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [MaxLength(50, ErrorMessage = "Atmost 50 characters are allowed")]
        public string CustomerName { get; set; }

        
        [MaxLength(10)]
        [Required(ErrorMessage = "Phone is required")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
                   ErrorMessage = "Entered phone format is not valid.")]
        public string CustomerPhone { get; set; }


        [Required(ErrorMessage = "Item Name is required")]
        [MinLength(3, ErrorMessage = "Minimum 3 characters are required")]
        [MaxLength(20 , ErrorMessage ="Maximum 20 characters are allowed")]
        public string ItemName { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1")]
        public int Quantity { get; set; }

        [MaxLength(200)]
        public string Notes { get; set; }
    }

}

