using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models
{
        public class Product
        {
            [Key]
            public int ProductId { get; set; }

            [Required(ErrorMessage = "Title is required")]
            [StringLength(100 ,ErrorMessage = "Titel Between 3 and 100", MinimumLength = 3 )]
            [DisplayName("Product Titel")]
            [MaxLength(100)]
            public string Title { get; set; }

            [Required(ErrorMessage = "Price is required")]
            [Range(0.1, 100000, ErrorMessage = "Price must be greater than 0")]
            public decimal Price { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [StringLength(500, ErrorMessage = "Description Between 3 and 500", MinimumLength = 3)]
        [DisplayName("Product Description")]
        [MaxLength(500)]
        public string Description { get; set; }


        [Required(ErrorMessage = "Quantity is required")]
        [Range(1, 1000, ErrorMessage = "Quantity must be at least 1")]
            public int Quantity { get; set; }
        [Required]
            public string ImagePath { get; set; }

        [DisplayName("Category")]
        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }

         public virtual Category Category { get; set; }
        }
    

}

