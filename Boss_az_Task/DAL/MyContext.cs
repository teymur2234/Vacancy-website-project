using Boss_az_Task.Entities;
using Microsoft.EntityFrameworkCore;

namespace Boss_az_Task.DAL
{
    public class MyContext:DbContext
    {
        public MyContext(DbContextOptions<MyContext> options):base(options)
        {
        }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Vacancy> Vacancies { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Resume> Resumes { get; set; }
        public DbSet<Comment> Comments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Role>().HasQueryFilter(t=> !t.IsDeleted);
            modelBuilder.Entity<User>().HasQueryFilter(t => !t.IsDeleted);
            modelBuilder.Entity<Permission>().HasQueryFilter(t => !t.IsDeleted);
            modelBuilder.Entity<Category>().HasQueryFilter(t => !t.IsDeleted);
            modelBuilder.Entity<City>().HasQueryFilter(t => !t.IsDeleted);
            modelBuilder.Entity<Education>().HasQueryFilter(t => !t.IsDeleted);
            modelBuilder.Entity<Experience>().HasQueryFilter(t => !t.IsDeleted);
            modelBuilder.Entity<Company>().HasQueryFilter(t => !t.IsDeleted);
            modelBuilder.Entity<Comment>().Property(t=>t.ShareDate).HasDefaultValueSql("GETDATE()");


            modelBuilder.Entity<Vacancy>().HasQueryFilter(t=> !t.IsActive);
            modelBuilder.Entity<Vacancy>().Property(t=>t.StartDate).HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<Vacancy>().Property(t => t.ExpiredTime).HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Resume>().Property(t=> t.StartDate).HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<Resume>().Property(t => t.ExpiredDate).HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<Resume>().HasQueryFilter(t=>!t.IsDeleted);

        }
    }
}
