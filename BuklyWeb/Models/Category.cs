using System.ComponentModel.DataAnnotations;

namespace BuklyWeb.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Kategoriya nomi kiritilishi shart")]
        [StringLength(100, ErrorMessage = "Kategoriya nomi 100 belgidan oshmasligi kerak")]
        [Display(Name = "Kategoriya nomi")]
        public string Name { get; set; }

        [Display(Name = "Tavsif")]
        [StringLength(500)]
        public string? Description { get; set; }

        // Navigation property
        public ICollection<Product>? Products { get; set; }


    }
}
