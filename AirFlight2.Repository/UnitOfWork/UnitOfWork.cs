using AirFlight2.Core.UnitOfWork;
using AirFlight2.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirFlight2.Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        //public readonly IUnitOfWork _unitOfWork;

        //public UnitOfWork(IUnitOfWork unitOfWork)
        //{
        //    _unitOfWork = unitOfWork;
        //}
        private readonly AppDbContext _context;
        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
