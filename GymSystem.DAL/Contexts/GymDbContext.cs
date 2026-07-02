using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymSystem.DAL.Configurations;
using GymSystem.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace GymSystem.DAL.Contexts
{
    public class GymDBContext : DbContext
    {
        public GymDBContext(DbContextOptions<GymDBContext> options):base(options) 
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Plan>(new PlanConfiguration());
        }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Trainer> Trainers
            { get; set; }
        public DbSet<Session> Sessions
            { get; set; }
        public DbSet<HealthRecord> HealthRecords { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Membership> Memberships { get; set; }



    }
}
