﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Domain.Models.Entities;
using Domain.Models.Enum;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.DBConfig
{
    class ProductConfig:  IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd().IsRequired();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Detail).IsRequired().HasMaxLength(500);
            builder.Property(x => x.DateCreate).IsRequired().HasDefaultValue(DateTime.Now);
            builder.Property(x => x.DateModified);
            builder.Property(x => x.CreateBy).IsRequired();
            builder.Property(x => x.ModifiedBy).IsRequired();
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.Status).IsRequired().HasDefaultValue(Status.Active);
         
           


        }
    }
}
