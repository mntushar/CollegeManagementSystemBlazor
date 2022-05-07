using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.DbContexts
{
    public class CollegeDbContext : DbContext
    {
        public DbSet<DepartmentModel> Department { get; set; }

        public CollegeDbContext()
        {
        }

        public CollegeDbContext(DbContextOptions<CollegeDbContext> options)
        : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //string ConnectionString = "Server=MNTUSHAR;Database=CollegeManagemantSystem;Trusted_Connection=True;MultipleActiveResultSets=true;";
            string ConnectionString = "Server=(localdb)\\mssqllocaldb;Database=CollegeManagemantSystem;Trusted_Connection=True;MultipleActiveResultSets=true";
        optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer(ConnectionString);
        }
    }
}
