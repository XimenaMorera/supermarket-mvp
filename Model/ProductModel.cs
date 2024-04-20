using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mevp.Model
{
    internal class ProductModel
    {
        [DisplayName("Product Id")]
        public int Product_Id { get; set; }

        [DisplayName("Product Name")]
        [Required(ErrorMessage = "Product name is requered")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Product name must be between 3 a 50 characters")]
        public string Product_Name { get; set; }

        [DisplayName("Observation")]
        [Required(ErrorMessage = "Product observation is required")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Product observation must be between 3 and 200 characters")]

        public string Observation { get; set; }
    }
}
