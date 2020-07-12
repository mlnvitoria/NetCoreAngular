using System.ComponentModel.DataAnnotations;

namespace booksapi.Models
{
    public class Entity
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public bool Removed { get; set; }
    }
}
