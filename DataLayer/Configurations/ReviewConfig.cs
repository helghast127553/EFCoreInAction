using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Configurations
{
    public class ReviewConfig : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> entity)
        {
            entity.HasKey(x => x.ReviewId);
            entity.Property(x => x.ReviewId).HasColumnType("int");
            entity.Property(x => x.NumStars).HasColumnType("int");
            entity.Property(x => x.Comment).HasColumnType("nvarchar(max)");
            entity.Property(x => x.VoterName).HasColumnType("nvarchar(100)");
        }
    }
}
