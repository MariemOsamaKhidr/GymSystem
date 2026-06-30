using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymSystem.DAL.Models;

namespace GymSystem.DAL.Repos.Interfaces
{
    public interface IPlanRepository
    {
        Task<IEnumerable<Plan>> GetAll();
        Task<Plan?> GetById(int ID);
        void Update(Plan plan);
        void Insert(Plan plan);
        void DeleteById(int id);
        Task<int> CompleteAsync();  //savechanges()


    }
}
