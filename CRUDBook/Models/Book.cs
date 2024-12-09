using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDBook.Models
{
    public class Book
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        [StringLength(100)]
        public string Author { get; set; }

        [StringLength(500)]
        public string? Description { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

        public string? ImagePath { get; set; }

        [NotMapped]
        public IFormFile? ImageFile { get; set; }


    }
}