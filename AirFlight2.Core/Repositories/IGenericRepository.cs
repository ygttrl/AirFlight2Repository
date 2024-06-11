using AirFlight2.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AirFlight2.Core.Repositories
{
    public interface IGenericRepository<Entity> where Entity : BaseEntity
    {
        Task<Entity> GetByIdAsync(int id);
        IQueryable<Entity> GetAll();


        IQueryable<Entity> Where(Expression<Func<Entity, bool>> expression);


        Task<bool> AnyAsync(Expression<Func<Entity, bool>> expression);


        Task AddAsync(Entity entity);


        Task<IEnumerable<Entity>> AddRangeAsync(IEnumerable<Entity>? entities);


        void Update(Entity entity);


        void Delete(Entity entity);
    }
}
