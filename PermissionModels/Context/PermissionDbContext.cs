using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using PermissionModels.Entities;
using PermissionModels.Entities.Base;

namespace PermissionModels.Context
{
    public class PermissionDbContext : BaseDbContext
    {
        public PermissionDbContext(DbContextOptions<PermissionDbContext> options) : base(options)
        {
        }

        public DbSet<Permission> Permissions { get; set; }
        public DbSet<PermissionType> PermissionTypes { get; set; }

        public DbSet<T> GetDbSet<T>() where T : class, IBaseEntity => Set<T>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Permission>().HasQueryFilter(x => !x.Deleted);
            modelBuilder.Entity<PermissionType>().HasQueryFilter(x => !x.Deleted);

            modelBuilder.Entity<PermissionType>().HasData(
                new PermissionType { Id = 1, Description = "Enfermedad", CreatedDate = DateTimeOffset.Now },
                new PermissionType { Id = 2, Description = "Diligencias", CreatedDate = DateTimeOffset.Now },
                new PermissionType { Id = 3, Description = "Otros", CreatedDate = DateTimeOffset.Now }
                );
        }
    }
}

