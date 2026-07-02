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
    internal class HealthRecordConfiguration : IEntityTypeConfiguration<HealthRecord>
    {
        public void Configure(EntityTypeBuilder<HealthRecord> builder)
        {
            builder.Property(x => x.Height).HasColumnType("decimal(5,2)").IsRequired();
            builder.Property(x => x.Weight).HasColumnType("decimal(5,2)").IsRequired();
            builder.Property(x => x.BloodType).HasColumnType("char").HasMaxLength(5);
            builder.Property(x => x.Note).HasMaxLength(300);




        }
    }
}
