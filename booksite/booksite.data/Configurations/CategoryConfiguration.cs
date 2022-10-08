using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using booksite.entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace booksite.data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(m=>m.CategoryId);

            builder.Property(m=>m.Name).IsRequired().HasMaxLength(100);

            builder.Property(m=>m.Url).IsRequired().HasMaxLength(100);

        }
    }
}