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
    public abstract class GymUserConfiguration<T> : IEntityTypeConfiguration<T> where T : GymUser
    {
        public void Configure(EntityTypeBuilder<T> builder)
        { 
            builder.Property(x => x.Name).HasColumnType("varchar").HasMaxLength(50);
            builder.Property(x => x.Email).HasColumnType("varchar").HasMaxLength(100);
            builder.OwnsOne(x => x.Address, address =>
            {
                address.Property(x => x.Street).HasColumnType("varchar").HasMaxLength(100);
                address.Property(x => x.City).HasColumnType("varchar").HasMaxLength(100);

            }
            );
            builder.Property(x => x.Phone).HasColumnType("char").HasMaxLength(11);
            builder.ToTable(x =>
            {
                x.HasCheckConstraint("EmailCheck", "Email like '%@%.%'");
                x.HasCheckConstraint("PhoneCheck", "Email like '[0-9]%' and LEN(Phone)=11");
            });
        }
    }
}
