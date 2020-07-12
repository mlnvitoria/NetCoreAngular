using System;
using System.ComponentModel.DataAnnotations;

namespace booksapi.Models
{
    public class Book : Entity
    {
        [Required(ErrorMessage = "The field 'title' is required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "The field 'summary' is required")]
        [MaxLength(1000, ErrorMessage = "The field 'summary' is too long")]
        public string Summary { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "The field 'price' must be greater than 1")]
        public int PagesQuantity { get; set; }
        
        [Required]
        public bool Virtual { get; set; }
        
        [Required(ErrorMessage = "The 'authorId' needs to be set")]
        [Range(1, long.MaxValue, ErrorMessage = "Invalid authorId")]

        public long AuthorId { get; set; }
        public Author Author { get; set; }
        
        [Range(1, long.MaxValue, ErrorMessage = "Invalid categoryId")]
        public long? CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
