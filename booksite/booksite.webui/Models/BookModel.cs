using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using booksite.entity;

namespace booksite.webui.Models
{
    public class BookModel
    {
        public int BookId { get; set; }
        public string Name { get; set; }
        [Required(ErrorMessage ="Url a required field.")]
        public string Url { get; set; }
        public double? Price { get; set; } 
        [Required(ErrorMessage ="Description a required field.")]
        [StringLength(100000,MinimumLength =5,ErrorMessage ="The book name should be in the range of 5-100000 characters!")]
        public string Description { get; set; } 
        public string ImageUrl { get; set; }
        public string BarcodeNumber { get; set; }
        [Required(ErrorMessage ="PageCount a required field.")]
        public int PageCount { get; set; }
        [Required(ErrorMessage ="FirstPrintDate a required field.")]
        public string FirstPrintDate { get; set; }
        public bool IsApproved { get; set; }
        public bool IsHome { get; set; }
        public int AuthorId { get; set; }
        public int PublisherId { get; set; }
        public List<Category> SelectedCategories { get; set; }
    }
}