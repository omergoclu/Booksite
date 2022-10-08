using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using booksite.entity;

namespace booksite.webui.Models
{
    public class PublisherModel
    {
        public int PublisherId { get; set; }
        [Required(ErrorMessage ="Publisher name is required.")]
        [StringLength(100,MinimumLength =1,ErrorMessage ="Please enter a value between 1-100 for the Publisher name.")]
        public string Name { get; set; }
        public List<Book> Books { get; set; }

    }
}