using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DataLayer.Configurations
{
    public class PriceOfferConfig : IEntityTypeConfiguration<PriceOffer>
    {
        public void Configure(EntityTypeBuilder<PriceOffer> entity)
        {
            entity.HasKey(x => x.PriceOfferId);
            entity.Property(x => x.PriceOfferId).HasColumnType("int");
            entity.Property(x => x.PromotionalText).HasColumnType("nvarchar(200)");
            entity.Property(x => x.NewPrice).HasColumnType("decimal(9, 2)");
        }
    }
}
