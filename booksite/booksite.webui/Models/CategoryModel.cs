using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using booksite.entity;

namespace booksite.webui.Models
{
    public class CategoryModel
    {
        public int CategoryId { get; set; }
        [Required(ErrorMessage ="Category name is required.")]
        [StringLength(100,MinimumLength =5,ErrorMessage ="Please enter a value between 5-100 for the category.")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Url is required.")]
        [StringLength(100,MinimumLength =5,ErrorMessage ="Please enter a value between 5-100 for the url.")]
        public string Url { get; set; }
        public List<Book> Books { get; set; }
        public List<BookCategory> BookCategories { get; set; }

    }
}