using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymSystem.DAL.Contexts;
using GymSystem.DAL.Models;
using GymSystem.DAL.Repos.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GymSystem.DAL.Repos.Classes
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly GymDBContext gymDBContext;

        public GenericRepository(GymDBContext gymDB)
        {
            gymDBContext = gymDB;
        }

        public async Task<int> CompleteAsync()
        {
            return await gymDBContext.SaveChangesAsync();
        }

        public void DeleteById(int id)
        {
            var entity = gymDBContext.Set<TEntity>().Find(id);
            if (entity is not null)
            {
                gymDBContext.Set<TEntity>().Remove(entity);
            }
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await gymDBContext.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity?> GetById(int ID)
        {
            return await gymDBContext.Set<TEntity>().FindAsync(ID);
        }

        public void Insert(TEntity entity)
        {
            gymDBContext.Set<TEntity>().Add(entity);
        }

        public void Update(TEntity entity)
        {
            gymDBContext.Set<TEntity>().Update(entity);
        }
    }
} 
