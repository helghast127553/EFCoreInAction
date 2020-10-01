using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DataLayer.Configurations
{
    public class LineItemConfig : IEntityTypeConfiguration<LineItem>
    {
        public void Configure(EntityTypeBuilder<LineItem> entity)
        {
            entity.HasKey(x => x.LineItemId);
            entity.Property(x => x.LineItemId).HasColumnType("int");
            entity.Property(x => x.OrderId).HasColumnType("int");
            entity.Property(x => x.BookId).HasColumnType("int");
            entity.Property(x => x.NumBooks).HasColumnType("smallint");
            entity.Property(x => x.LineNum).HasColumnType("tinyint");
            
            //relationships
            entity.HasOne(x => x.ChosenBook).WithMany().OnDelete(DeleteBehavior.Restrict);
        }
    }
}
