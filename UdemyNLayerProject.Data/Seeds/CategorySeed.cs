﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using UdemyNLayerProject.Core.Models;

namespace UdemyNLayerProject.Data.Seeds
{
    class CategorySeed:IEntityTypeConfiguration<Category>
    {
        private readonly int[] _ids;
        
        public CategorySeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { Id= _ids[0], Name="Kalemler"},
                new Category { Id= _ids[1], Name="Defterler"}
                );
        }
    }
}
