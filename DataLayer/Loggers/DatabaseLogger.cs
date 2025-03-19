using Microsoft.EntityFrameworkCore;
using WelcomeExtended.Model;
using Welcome.Others;


namespace WelcomeExtended.Loggers
{
    public class DatabaseContext : DbContext
    {
        public DbSet<DatabaseUser> Users { get; set; }
        public DbSet<LogEntry> Logs { get; set; } // Ensure Logs table is registered

        public DatabaseContext()
        {
            this.Database.EnsureCreated(); // 🔹 Ensures database tables are created
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string solutionFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string databaseFile = "Welcome.db";
            string databasePath = Path.Combine(solutionFolder, databaseFile);
            optionsBuilder.UseSqlite($"Data Source={databasePath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DatabaseUser>()
                .Property(u => u.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<LogEntry>()
                .Property(l => l.Id)
                .ValueGeneratedOnAdd();

            // 🔹 Use static values for Id instead of negative values
            modelBuilder.Entity<DatabaseUser>().HasData(
                new DatabaseUser("admin", "admin123", UserRolesEnum.ADMIN, "111111", "admin@example.com") { Id = 1 },
                new DatabaseUser("student1", "student123", UserRolesEnum.STUDENT, "222222", "student1@example.com") { Id = 2 },
                new DatabaseUser("teacher", "teacher123", UserRolesEnum.PROFESSOR, "333333", "teacher@example.com") { Id = 3 }
            );
        }
    }
}
