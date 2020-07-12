using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace booksapi.Models
{
    public class Author : Entity
    {
        [Required(ErrorMessage = "The field 'Name' is required")]
        public string Name { get; set; }
        public string PhotoPath { get; set; }
        public string Biography { get; set; }
        
        public List<Book> Books { get; set; }
    }
}
