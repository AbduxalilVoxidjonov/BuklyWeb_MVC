using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BuklyWeb.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Mahsulot nomi kiritilishi shart")]
        [StringLength(200, MinimumLength = 2, ErrorMessage = "Mahsulot nomi 2 dan 200 belgigacha bo'lishi kerak")]
        [Display(Name = "Mahsulot nomi")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Narx kiritilishi shart")]
        [Range(0.01, 1000000, ErrorMessage = "Narx 0.01 dan 1,000,000 gacha bo'lishi kerak")]
        [Display(Name = "Narxi")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Tavsif kiritilishi shart")]
        [StringLength(1000, MinimumLength = 10, ErrorMessage = "Tavsif 10 dan 1000 belgigacha bo'lishi kerak")]
        [Display(Name = "Tavsif")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        // Foreign Key
        [Required(ErrorMessage = "Kategoriya tanlanishi shart")]
        [Display(Name = "Kategoriya")]
        public int CategoryId { get; set; }

        [Display(Name = "Rasm URL")]
        [DataType(DataType.Url)]
        [StringLength(500)]
        public string? ImageUrl { get; set; }

        // Navigation property
        [ForeignKey("CategoryId")]
        public Category? Category { get; set; }
    }
}