using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BudgetManagement.DataAccess.Identity;
using BudgetManagement.DataAccess.Persistence;
using System;
using System.Threading.Tasks;

namespace BudgetManagement.Common
{
    public static class AutomatedMigration
    {
        public static async Task MigrateAsync(IServiceProvider services)
        {
            var context = services.GetRequiredService<DatabaseContext>();

            if (context.Database.IsSqlServer())
            {
                await context.Database.MigrateAsync();
            }

            var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();

            await DatabaseContextSeed.SeedDatabaseAsync(context, userManager);
        }
    }
}
