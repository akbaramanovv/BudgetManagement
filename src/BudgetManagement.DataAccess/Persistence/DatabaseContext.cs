﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BudgetManagement.Core.Common;
using BudgetManagement.Core.Entities;
using BudgetManagement.DataAccess.Identity;
using BudgetManagement.Shared.Services;
using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace BudgetManagement.DataAccess.Persistence
{
    public class DatabaseContext : IdentityDbContext<ApplicationUser>
    {
        private readonly IClaimService _claimService;

        public DatabaseContext(DbContextOptions options, IClaimService claimService) : base(options)
        {
            _claimService = claimService;
        }

        public DbSet<TodoItem> TodoItems { get; set; }
        public DbSet<TodoList> TodoLists { get; set; }
        public DbSet<AnnualBudget> AnnualBudgets { get; set; }
        public DbSet<EmployeeOutgoing> EmployeeOutgoings { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }

        public new async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new())
        {
            foreach (var entry in ChangeTracker.Entries<IAuditedEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = _claimService.GetUserId();
                        entry.Entity.CreatedOn = DateTime.Now;
                        break;
                    case EntityState.Modified:
                        entry.Entity.UpdatedBy = _claimService.GetUserId();
                        entry.Entity.UpdatedOn = DateTime.Now;
                        break;
                }
            }

            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
