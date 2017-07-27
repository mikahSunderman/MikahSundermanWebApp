using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MikahSundermanWebApp.Models
{
    public static class DBinitialize
    {
        public static void EnsureCreated(IServiceProvider serviceProvider)
        {
            var context = new MikahSundermanWebAppContext(
                serviceProvider.GetRequiredService<DbContextOptions<MikahSundermanWebAppContext>>());
            context.Database.EnsureCreated();
        }
    }
}
