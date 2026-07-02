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
    internal class SessionConfiguration : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
            builder.ToTable(x => {
                x.HasCheckConstraint("SessionDateCheck","EndDate >StartDate");
                x.HasCheckConstraint("SessionCapacity", "Capacity between 1 and 25");

            });
        }
    }
}
