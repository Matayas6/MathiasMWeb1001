using MathiasMumbohWeb1001.Pages.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MathiasMumbohWeb1001.Pages.Models
{
    public class AuthorClass
    {
        [Required]
        public string First_Name { get; set; }

        [Required]
        public string Last_Name { get; set; }

        [DataType(DataType.Date)]
        public int Birthday { get; set; }

        [EmailAddress]
        [Key]
        [Required(ErrorMessage = "Enter a valid Email address.")]
        public string Email { get; set; }

        public string Website { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        public string Country { get; set; }

        public string Province { get; set; }

        [DataType(DataType.PostalCode)]
        public string ZipCode { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        

        public ICollection<BlogClass> BlogClass { get; set; }
    }
}
