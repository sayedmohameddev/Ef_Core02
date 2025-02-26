using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ef_Core_Demo_Session02.Configurations;
using Ef_Core_Demo_Session02.Entities;
using EF_Core_Session02_Demo.Entities;
using Microsoft.EntityFrameworkCore;

namespace EF_Core_Session02_Demo.Contexts
{
    internal class AppDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-PEC2QL2\\SQLEXPRESS; Database = AppOne; Trusted_Connection = True; TrustServerCertificate = True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            //modelBuilder.Entity<Employee>().HasOne(E => E.department)
            //                               .WithOne(D => D.Manager)
            //                               .HasForeignKey<Department>(D => D.EmpId);

            //modelBuilder.Entity<Department>().HasMany(D => D.Employees)
            //                               .WithOne(E => E.WorkFor)
            //                               .HasForeignKey(D => D.WorkForId);

            modelBuilder.Entity<StudentCourse>().HasKey(sc => new {sc.CourseId , sc.StudentId});

        }
        public DbSet<Employee> employees { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<Course> courses{ get; set; }
    }
}
