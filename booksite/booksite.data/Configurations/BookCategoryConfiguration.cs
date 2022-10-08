using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using booksite.entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace booksite.data.Configurations
{
    public class BookCategoryConfiguration : IEntityTypeConfiguration<BookCategory>
    {
        public void Configure(EntityTypeBuilder<BookCategory> builder)
        {
           builder.HasKey(c => new { c.CategoryId, c.BookId });
        }
    }
}