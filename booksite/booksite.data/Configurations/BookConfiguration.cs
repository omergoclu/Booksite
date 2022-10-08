using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using booksite.entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace booksite.data.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(m=>m.BookId);

            builder.Property(m=>m.Name).IsRequired().HasMaxLength(100);

            builder.Property(m=>m.Url).IsRequired().HasMaxLength(100);

            builder.Property(m=>m.DateAdded).HasDefaultValueSql("getdate()"); //mssql
            // builder.Property(m=>m.DateAdded).HasDefaultValueSql("date('now')"); //sqlite

        }
    }
}