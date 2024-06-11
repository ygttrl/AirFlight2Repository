using AirFlight2.Entities.Models;
using AirFlight2.Repository.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AirFlight2.Repository.Repositories
{
    public class GenericRepository<Entity> : Core.Repositories.IGenericRepository<Entity> where Entity : BaseEntity
    {
        protected readonly AppDbContext _context;
        public readonly DbSet<Entity> _dbSet;

        //public GenericRepository(AppDbContext context, DbSet<Entity> dbSet)
        //{
        //    this._context = context;
        //    this._dbSet = _context.Set<Entity>();
        //}

        public GenericRepository(AppDbContext context)
        {
            this._context = context;
            this._dbSet = _context.Set<Entity>();
        }

        public async Task AddAsync(Entity entity)
        {
            await _context.AddAsync(entity);
        }

        public async Task<IEnumerable<Entity>> AddRangeAsync(IEnumerable<Entity>? entities)
        {
            await _context.AddRangeAsync(entities);
            return entities;
        }

        public async Task<bool> AnyAsync(Expression<Func<Entity, bool>> expression)
        {
            return await _dbSet.AnyAsync(expression);
        }

        public void Delete(Entity entity)
        {
            _dbSet.Remove(entity);
        }

        public IQueryable<Entity> GetAll()
        {
            return _dbSet.AsNoTracking().AsQueryable();
        }

        public async Task<Entity> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public void Update(Entity entity)
        {
            _dbSet.Update(entity);
        }

        public IQueryable<Entity> Where(Expression<Func<Entity, bool>> expression)
        {
            return _dbSet.Where(expression).AsQueryable();
        }
    }
}
