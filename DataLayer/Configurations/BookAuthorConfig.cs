using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DataLayer.Configurations
{
    public class BookAuthorConfig : IEntityTypeConfiguration<BookAuthor>
    {
        public void Configure(EntityTypeBuilder<BookAuthor> entity)
        {
            entity.HasKey(x => new { x.BookId, x.AuthorId });
            entity.Property(x => x.BookId).HasColumnType("int");
            entity.Property(x => x.AuthorId).HasColumnType("int");
            entity.Property(x => x.Order).HasColumnType("tinyint");

            //relationships
            entity.HasOne(x => x.Book).WithMany(x => x.AuthorsLink).HasForeignKey(x => x.BookId);
            entity.HasOne(x => x.Author).WithMany(x => x.BooksLink).HasForeignKey(x => x.AuthorId);
        }
    }
}
