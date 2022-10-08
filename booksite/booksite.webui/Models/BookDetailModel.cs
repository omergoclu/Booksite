using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using booksite.entity;

namespace booksite.webui.Models
{
    public class BookDetailModel
    {
        public Book Book { get; set; }
        public List<Category> Categories { get; set; }
        public List<Author> Authors { get; set; }
        public List<Publisher> Publishers { get; set; }
    }
}