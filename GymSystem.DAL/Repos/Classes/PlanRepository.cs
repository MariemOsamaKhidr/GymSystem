using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using GymSystem.DAL.Contexts;
using GymSystem.DAL.Models;
using GymSystem.DAL.Repos.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GymSystem.DAL.Repos.Classes
{
    public class PlanRepository : IGenericRepository<Plan>
    {
        private readonly GymDBContext gymDBContext;
        public PlanRepository(GymDBContext _gymDBContext)
        {
            gymDBContext = _gymDBContext;
        }

        public async Task<int> CompleteAsync()
        {
            return await gymDBContext.SaveChangesAsync();   
        }

        public void DeleteById(int id)
        {
            var plan = gymDBContext.Plans.FirstOrDefault(x=>x.Id==id);
            if (plan is not null)
            {
                gymDBContext.Plans.Remove(plan);
            }
        }

        public async Task<IEnumerable<Plan>> GetAll()
        {
            return await gymDBContext.Plans.ToListAsync();
        }

        public async Task<Plan?> GetById(int ID)
        {
            return await gymDBContext.Plans.FirstOrDefaultAsync(x=>x.Id==ID); 
        }

        public void Insert(Plan plan)
        {
             gymDBContext.Plans.AddAsync(plan);
        }

        public  void Update(Plan plan)
        {
           gymDBContext.Plans.Update(plan);

        }
    }
}
