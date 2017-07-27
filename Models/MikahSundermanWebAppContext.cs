using Microsoft.EntityFrameworkCore;

namespace MikahSundermanWebApp.Models
{
    public class MikahSundermanWebAppContext : DbContext
    {
        public MikahSundermanWebAppContext(DbContextOptions<MikahSundermanWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<MikahSundermanWebApp.Models.Education> Education { get; set; }
        public DbSet<MikahSundermanWebApp.Models.WorkExperience> WorkExperience { get; set; }
        public DbSet<MikahSundermanWebApp.Models.ProgrammingLanguage> ProgrammingLanguage { get; set; }
        public DbSet<MikahSundermanWebApp.Models.FrameworkAPI> FrameworkAPI { get; set; }
    }
}