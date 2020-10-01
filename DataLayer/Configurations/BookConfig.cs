using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DataLayer.Configurations
{
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> entity)
        {
            entity.HasKey(x => x.BookId);
            entity.Property(x => x.BookId).HasColumnType("int");
            entity.Property(x => x.Title).HasColumnType("nvarchar(256)");
            entity.Property(x => x.Publisher).HasColumnType("nvarchar(64)");
            entity.Property(x => x.PublishedOn).HasColumnType("date");
            entity.Property(x => x.Description).HasColumnType("nvarchar(256)");
            entity.Property(x => x.Price).HasColumnType("decimal(9, 2)");
            entity.Property(x => x.SoftDeleted).HasColumnType("bit");
            entity.Property(x => x.ImageUrl).IsUnicode(false);
            entity.HasIndex(x => x.PublishedOn);
            entity.HasQueryFilter(x => !x.SoftDeleted);

            //relationships
            entity.HasOne(x => x.Promotion).WithOne().HasForeignKey<PriceOffer>(x => x.PriceOfferId);
            entity.HasMany(x => x.Reviews).WithOne().HasForeignKey(x => x.BookId);
        }
    }
}
