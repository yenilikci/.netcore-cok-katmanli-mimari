using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UdemyNLayerProject.Core.Models;

namespace UdemyNLayerProject.Data.Configurations
{
    class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            //primary key Id olsun
            builder.HasKey(x => x.Id);
            //Id değeri 1'er artacak
            builder.Property(x => x.Id).UseIdentityColumn();
            //Name zorunlu olsun, 50 karakter uzunluğunda
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            //Tablo adı
            builder.ToTable("Categories"); //.ToTable("tabloAdi","semaAdi");

        }
    }
}
