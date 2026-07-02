using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymSystem.DAL.Models
{
    public class Session:BaseEntity
    {
        public string Describition { get; set; } = default!;
        public int capacity {  get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int CategoryId { get; set; }
        public Category  Category { get; set; }= default!;
        public int TrainerId { get; set; }

        public Trainer Trainer { get; set; } = default!;
        public ICollection<Booking> SessionMembers { get; set; } = [];






    }
}
