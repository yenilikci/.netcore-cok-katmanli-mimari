using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UdemyNLayerProject.Core.Models;

namespace UdemyNLayerProject.Data.Configurations
{
    class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            //primary key belirleme
            builder.HasKey(x => x.Id);
            //Id 1'er artsın
            builder.Property(x => x.Id).UseIdentityColumn();
            //Name gerekli olsun, max uzunluğu 200 karakter olsun
            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);
            //Stok zorunlu olsun
            builder.Property(x => x.Stock).IsRequired();
            //Price zorunlu olsun, decimal toplam 18 karakterli olsun virgülden sonra da 2 karakter alabilsin
            builder.Property(x => x.Price).IsRequired().HasColumnType("decimal(18,2)");
            //InnerBarcode maksimum 50 karakter olsun
            builder.Property(x => x.InnerBarcode).HasMaxLength(50);
            //Tablo adı
            builder.ToTable("Products");
        }
    }
}
