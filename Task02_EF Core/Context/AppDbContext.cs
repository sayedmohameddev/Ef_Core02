using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Task01.Entities;
using Task01_.Validations;

namespace Task01_.Context
{
    internal class AppDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Fluent APIs

            //    modelBuilder.Entity<Student>(S =>
            //{
            //    S.HasKey(S => S.ID);
            //    S.Property(S => S.FName)
            //     .HasColumnType("VARCHAR")
            //     .HasMaxLength(50)
            //     .IsRequired()
            //     .HasColumnName("Fname");
            //    S.Property(S => S.LName)
            //     .HasColumnType("VARCHAR")
            //     .HasMaxLength(50)
            //     .IsRequired()
            //     .HasColumnName("LName");
            //    S.Property(S => S.Address)
            //     .HasColumnName("address")
            //     .IsRequired()
            //     .HasColumnType("NVARCHAR");
            //    S.Property(S => S.Age)
            //     .IsRequired(false);
            //    S.Property(S => S.Dep_Id)
            //     .IsRequired();
            //});

            //    modelBuilder.Entity<Course>(C =>
            //    {
            //        C.HasKey(C => C.ID);
            //        C.Property(C => C.Name)
            //         .HasColumnName("Name")
            //         .IsRequired()
            //         .HasColumnType("VARCHAR")
            //         .HasMaxLength(50);
            //        C.Property(C => C.Description)
            //        .HasColumnName("Description")
            //        .IsRequired(false)
            //        .HasColumnType("VARCHAR")
            //        .HasMaxLength(300);
            //        C.Property(C => C.Duration)
            //         .IsRequired(true);
            //        C.Property(C => C.Top_ID)
            //         .IsRequired(true);
            //    });

            //    modelBuilder.Entity<Course_Inst>(CI =>
            //    {
            //        CI.HasKey(CI => new { CI.Course_ID, CI.Course_InstID });
            //        CI.Property(CI => CI.evaluation)
            //          .IsRequired();
            //    });

            //    modelBuilder.Entity<Department>(D =>
            //    {
            //        D.HasKey(D => D.ID);
            //        D.Property(D => D.Name)
            //         .IsRequired()
            //         .HasMaxLength(200)
            //         .HasColumnName("DepartmentName");
            //        D.Property(D => D.Ins_ID)
            //         .IsRequired();
            //        D.Property(D => D.HiringDate)
            //         .IsRequired(false)
            //         .HasDefaultValueSql("GETDATE()");
            //    });

            //    modelBuilder.Entity<Instructor>(I =>
            //    {
            //        I.HasKey(I => I.ID);
            //        I.Property(I => I.Name)
            //         .IsRequired()
            //         .HasMaxLength(200)
            //         .HasColumnName("InstructorName");
            //        I.Property(I => I.Bonus)
            //         .HasColumnType("money");
            //        I.Property(I => I.Salary)
            //         .HasColumnType("money");
            //        I.Property(I => I.HourRate)
            //         .HasColumnType("money");
            //        I.Property(I => I.Address)
            //         .HasColumnName("address")
            //         .HasMaxLength(200);
            //        I.Property(I => I.Dept_ID)
            //         .IsRequired();
            //    });

            //    modelBuilder.Entity<Stud_Course>(SC =>
            //    {
            //        SC.HasKey(CI => new { CI.Stud_CourseID, CI.Course_ID });
            //        SC.Property(SC => SC.Grade)
            //          .IsRequired(false)
            //          .HasColumnType("float");
            //    });

            //    modelBuilder.Entity<Topic>(T =>
            //    {
            //        T.HasKey(T => T.ID);
            //        T.Property(T => T.Name)
            //         .IsRequired()
            //         .HasMaxLength(200)
            //         .HasColumnName("TopicName");

            //    }); 
            #endregion

            modelBuilder.ApplyConfiguration(new StudentValidations());
            modelBuilder.ApplyConfiguration(new CourseValidations());
            modelBuilder.ApplyConfiguration(new Course_InstValidations());
            modelBuilder.ApplyConfiguration(new DepartmentValidations());
            modelBuilder.ApplyConfiguration(new InstructorValidations());
            modelBuilder.ApplyConfiguration(new Stud_CourseValidations());
            modelBuilder.ApplyConfiguration(new TopicValidations());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-PEC2QL2\\SQLEXPRESS; Database = App03; Trusted_Connection = True; TrustServerCertificate = True");
        }

        public DbSet<Student> students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Course_Inst> Course_Insts { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> instructors { get; set; }
        public DbSet<Stud_Course> Stud_Courses { get; set; }
        public DbSet<Topic> topics { get; set; }

    }
}
