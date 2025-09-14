using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }




        [StringLength(50)]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Description is required")]
        [StringLength(500, ErrorMessage = "Description Between 3 and 500", MinimumLength = 3)]
        [DisplayName("Product Description")]
        [MaxLength(500)]
        public string Description { get; set; }



        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }

}
