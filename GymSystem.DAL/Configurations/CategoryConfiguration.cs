
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymSystem.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymSystem.DAL.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(x => x.CategoryName).HasColumnType("varchar").HasMaxLength(50);
            builder.HasData(
                new Category { Id=1,CategoryName="Yoga"},
                new Category { Id = 2, CategoryName = "Gym" },
                new Category { Id = 3, CategoryName = "CrossFit" },
                new Category { Id = 4, CategoryName = "Boxing" }
             );


            
        }
    }
}
