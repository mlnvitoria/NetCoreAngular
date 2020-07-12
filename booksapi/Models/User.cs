using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace booksapi.Models
{
    public class User : Entity
    {
        [Required(ErrorMessage = "The field 'Name' is required")]
        [MinLength(2, ErrorMessage = "The field 'Name' is too short")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "The field 'LastName' is required")]
        [MinLength(2, ErrorMessage = "The field 'Last Name' is too short")] 
        public string LastName { get; set; }
        
        [Required(ErrorMessage = "The field 'E-mail' is required")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "The field 'Password' is required")]
        public string Password { get; set; }
    }
}
