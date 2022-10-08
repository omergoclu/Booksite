using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace booksite.entity
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string NameLastName { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public List<Book> Books { get; set; }

    }
}