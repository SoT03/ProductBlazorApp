using System.ComponentModel.DataAnnotations;
namespace ProductBlazorApp.Models

{
    public class Product
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(40, ErrorMessage = "Name cannot exceed 40 characters")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Price is required")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than zero")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters")]
        public string Description { get; set; } = string.Empty;
    }
}
