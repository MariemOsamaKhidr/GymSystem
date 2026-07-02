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
    internal class TrainerConfiguration : GymUserConfiguration<Trainer>,IEntityTypeConfiguration<Trainer>
    {
        public new void Configure(EntityTypeBuilder<Trainer> builder)
        {
            builder.Property(x => x.Speciality).HasConversion<string>();
            base.Configure(builder);
        }
    }
}
