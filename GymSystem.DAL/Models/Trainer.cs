using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymSystem.DAL.Models.Enums;

namespace GymSystem.DAL.Models
{
    public class Trainer:GymUser
    {
        public Specialities Speciality { get; set; }
        public ICollection<Session> Sessions {  get; set; } 

         
    }
}
