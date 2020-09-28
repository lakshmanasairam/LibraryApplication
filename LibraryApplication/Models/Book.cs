using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApplication.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Enter a Book Name")]
        [Display(Name ="Book Name")]
        public string BookName { get; set; }

        [Required(ErrorMessage = "Enter the Author")]
        [Display(Name = "Author Name")]
        public string Author { get; set; }

        public string ISBN { get; set; }

        [Display(Name = "Published Date")]
        [DataType(DataType.DateTime)]
        public DateTime PublishedDate { get; set; }

        public string Genre { get; set; }
    }
}
