using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymSystem.DAL.Models
{
    public class Membership :BaseEntity
    {
        public Member Member { get; set; } = default!;
        public Plan Plan { get; set; } = default!;
        public int PlanId { get; set; }
        public int MemberId { get; set; }
        public DateOnly EndDate { get; set; }
        [NotMapped]
        public bool IsActive => EndDate > DateOnly.FromDateTime(DateTime.Now);
        [NotMapped]
        public string? Status => IsActive ? "Active" : "Inactive";



    }
}
