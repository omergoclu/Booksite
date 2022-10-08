using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace booksite.entity
{
    public class Book
    {
        public int BookId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public double? Price { get; set; } 
        public string Description { get; set; } 
        public string ImageUrl { get; set; }
        public string BarcodeNumber { get; set; }
        public int PageCount { get; set; }
        public string FirstPrintDate { get; set; }
        public bool IsApproved { get; set; }
        public bool IsHome { get; set; }
        public DateTime DateAdded { get; set; }
        public List<BookCategory> BookCategories { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }

    }
}