using AirFlight2.Entities.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AirFlight2.Repository.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> context) : base(context)
        {

        }

        public DbSet<Country> Countries { get; set; }

        public DbSet<AirPort> AirPorts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            UpdateChangeTraker();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        public override int SaveChanges()
        {
            UpdateChangeTraker();
            return base.SaveChanges();
        }

        public void UpdateChangeTraker()
        {

            foreach (var item in ChangeTracker.Entries())
            {
                if (item.Entity is BaseEntity entityReferance)
                {

                    switch (item.Entity)
                    {

                        case EntityState.Added:

                            Entry(entityReferance).Property(x => x.UpdatedDate).IsModified = false;
                            entityReferance.CreatedDate = DateTime.Now;
                            break;

                        case EntityState.Modified:
                            Entry(entityReferance).Property(x => x.CreatedDate).IsModified = false;
                            entityReferance.UpdatedDate = DateTime.Now;
                            break;

                    }

                }
            }

        }


    }
}
