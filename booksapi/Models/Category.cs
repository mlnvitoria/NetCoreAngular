using System.ComponentModel.DataAnnotations;

namespace booksapi.Models
{
    public class Category
    {
        [Key]
        public long Id { get; set; }

        [Required(ErrorMessage = "The 'title' field is required")]
        [MinLength(3, ErrorMessage = "The 'title' field is too short.")]
        [MaxLength(150, ErrorMessage = "The 'title' field is too long.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "The 'code' field is required")]
        [MinLength(3, ErrorMessage = "The 'code' field is too short.")]
        [MaxLength(100, ErrorMessage = "The 'code' field is too long.")]
        public string UrlCode { get; set; }
    }
}
