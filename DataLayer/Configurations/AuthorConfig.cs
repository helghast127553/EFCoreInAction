using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DataLayer.Configurations
{
    public class AuthorConfig : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> entity)
        {
            entity.HasKey(x => x.AuthorId);
            entity.Property(x => x.AuthorId).HasColumnType("int");
            entity.Property(x => x.Name).HasColumnType("nvarchar(1000)");
        }
    }
}
