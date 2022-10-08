using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using booksite.entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace booksite.data.Configurations
{
    public class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.HasKey(m=>m.Id);
        }
    }
}