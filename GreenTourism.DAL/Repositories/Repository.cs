using GreenTourism.Domain.Entities;
using GreenTourism.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GreenTourism.DAL.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
    {
        protected readonly DbContext dbContext;

        public Repository(DbContext dbContext)
        {
            this.dbContext = dbContext;
        } 

        public async Task<TEntity> CreateAsync(TEntity entity)
        {
            return (await dbContext.Set<TEntity>().AddAsync(entity)).Entity;
        }

        public async Task DeleteAsync(TEntity entity)
        {
            dbContext.Set<TEntity>().Remove(entity);
        }

        public async Task DeleteAsync(long id)
        {
            var entity = await FindById(id);

            if (entity != null)
            {
                await DeleteAsync(entity);
            }
        }

        public async Task<List<TEntity>> FindAll()
        {
            return await dbContext.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> FindById(long id)
        {
            return await dbContext.Set<TEntity>().FindAsync(id);
        }

        public async Task SaveChanges()
        {
            await dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            dbContext.Set<TEntity>().Update(entity);
        }
    }
}
