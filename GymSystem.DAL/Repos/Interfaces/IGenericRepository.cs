using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymSystem.DAL.Models;

namespace GymSystem.DAL.Repos.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class 
    {
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity?> GetById(int ID);
        void Update(TEntity entity);
        void Insert(TEntity entity);
        void DeleteById(int id);
        Task<int> CompleteAsync();
    }
}
