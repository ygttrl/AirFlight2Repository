using AirFlight2.Core.Repositories;
using AirFlight2.Core.Services;
using AirFlight2.Core.UnitOfWork;
using AirFlight2.Dto.Dtos;
using AirFlight2.Entities.Models;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
 

namespace AirFlight2.Service.Services
{
    public class Service<Entity, Dto> : IService<Entity, Dto> where Entity : BaseEntity where Dto : BaseDto
    {

        public readonly IGenericRepository<Entity> repository;
        public readonly IUnitOfWork unitOfWork;
        public readonly IMapper mapper;

        public Service(IGenericRepository<Entity> repository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<ResponceDto<Dto>> AddAsync(Dto dto)
        {
            var Entity = mapper.Map<Entity>(dto);
            await repository.AddAsync(Entity);
            await unitOfWork.CommitAsync();
            return ResponceDto<Dto>.Success(StatusCodes.Status201Created, dto);
        }

        public async Task<ResponceDto<IEnumerable<Dto>>> AddRangeRepository(IEnumerable<Dto> dtoList)
        {
            var entities = mapper.Map<IEnumerable<Entity>>(dtoList);

            await repository.AddRangeAsync(entities.ToList());
            await unitOfWork.CommitAsync();

            return ResponceDto<IEnumerable<Dto>>.Success(StatusCodes.Status201Created, dtoList);
        }

        public async Task<ResponceDto<bool>> AnyAsync(Expression<Func<Entity, bool>> expression)
        {

            var anyEntity = await repository.AnyAsync(expression);
            return ResponceDto<bool>.Success(StatusCodes.Status200OK, anyEntity);
        }

        public async Task<ResponceDto<NoContentDto>> DeleteAsync(int id)
        {
            var entity = await repository.GetByIdAsync(id);
            repository.Delete(entity);
            unitOfWork.Commit();
            return ResponceDto<NoContentDto>.Success(StatusCodes.Status204NoContent);
        }

        public async Task<ResponceDto<IEnumerable<Dto>>> GetAllAsync()
        {
            var Entities = repository.GetAll().ToList();
            var newDto = mapper.Map<IEnumerable<Dto>>(Entities);
            return ResponceDto<IEnumerable<Dto>>.Success(StatusCodes.Status200OK, newDto);
        }

        public async Task<ResponceDto<Dto>> GetByIdAsync(int id)
        {
            var entity = await repository.GetByIdAsync(id);

            var entityDto = mapper.Map<Dto>(entity);

            return ResponceDto<Dto>.Success(StatusCodes.Status200OK, entityDto);
        }

        public async Task<ResponceDto<NoContentDto>> UpdateAsync(Dto dto)
        {
            var entity = mapper.Map<Entity>(dto);
            repository.Update(entity);
            unitOfWork.Commit();
            return ResponceDto<NoContentDto>.Success(StatusCodes.Status204NoContent);
        }

        public async Task<ResponceDto<IEnumerable<Dto>>> Where(Expression<Func<Entity, bool>> expression)
        {
            var entity = repository.Where(expression);
            var entityDto = mapper.Map<IEnumerable<Dto>>(entity);
            return ResponceDto<IEnumerable<Dto>>.Success(StatusCodes.Status200OK, entityDto);
        }
    }
}
