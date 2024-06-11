using AirFlight2.Dto.Dtos;
using AirFlight2.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AirFlight2.Core.Services
{
    public interface IService<Entity, Dto> where Entity : BaseEntity where Dto : BaseDto
    {
        Task<ResponceDto<Dto>> GetByIdAsync(int id);
        Task<ResponceDto<IEnumerable<Dto>>> GetAllAsync();
        Task<ResponceDto<IEnumerable<Dto>>> Where(Expression<Func<Entity, bool>> expression);
        Task<ResponceDto<bool>> AnyAsync(Expression<Func<Entity, bool>> expression);
        Task<ResponceDto<Dto>> AddAsync(Dto dto);
        Task<ResponceDto<IEnumerable<Dto>>> AddRangeRepository(IEnumerable<Dto> dtoList);
        Task<ResponceDto<NoContentDto>> UpdateAsync(Dto dto);
        Task<ResponceDto<NoContentDto>> DeleteAsync(int id);
    }
}
