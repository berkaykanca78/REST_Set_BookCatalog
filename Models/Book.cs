using System.ComponentModel.DataAnnotations;

namespace BookCatalog.Models
{
    public class Book
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [Range(1,100)]
        public decimal Price { get; set; }
    }
}
