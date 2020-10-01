using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DataLayer.Configurations
{
    public class OrderConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> entity)
        {
            entity.HasKey(x => x.OrderId);
            entity.Property(x => x.OrderId).HasColumnType("int");
            entity.Property(x => x.CustomerName).HasColumnType("uniqueidentifier");
            entity.Property(x => x.DateOrderedUtc).HasColumnType("datetime");
        }
    }
}
