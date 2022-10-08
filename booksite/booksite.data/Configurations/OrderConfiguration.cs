using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using booksite.entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace booksite.data.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(m=>m.Id);

            builder.Property(m=>m.FirstName).IsRequired().HasMaxLength(100);

            builder.Property(m=>m.LastName).IsRequired().HasMaxLength(100);

        }
    }
}