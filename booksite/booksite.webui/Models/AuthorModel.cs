using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using booksite.entity;

namespace booksite.webui.Models
{
    public class AuthorModel
    {
        public int AuthorId { get; set; }
        [Required(ErrorMessage ="Author namelastname is required.")]
        [StringLength(100,MinimumLength =1,ErrorMessage ="Please enter a value between 1-100 for the author name.")]
        public string NameLastName { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public List<Book> Books { get; set; }
    }
}