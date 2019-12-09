using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PTC.Data
{
    public class TrainingProduct
    {
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Product Name must be filled in.")]
        [Display(Description = "Product Name")]
        [StringLength(150, MinimumLength = 4, ErrorMessage = "Product Name must be grater than {2} characters and less than {1} characters.")]
        public string ProductName { get; set; }
        [Range(typeof(DateTime), "2000-01-01", "2020-12-31", ErrorMessage = "Introduction Date must be between {1} and {2}")]
        [Display(Description = "Introduction Date")]
        public DateTime IntroductionDate { get; set; }
        [Required(ErrorMessage = "Url must be filled in.")]
        [Display(Description = "URL")]
        [StringLength(2000, MinimumLength = 5, ErrorMessage = "URL must be grater than {2} characters and less than {1} characters.")]
        public string Url { get; set; }
        [Range(1, 9999, ErrorMessage = "{0} must be between {1} and {2}")]
        public decimal Price { get; set; }
    }
}
