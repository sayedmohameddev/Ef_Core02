using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Task01.Entities;

namespace Task01_.Validations
{
    internal class DepartmentValidations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> D)
        {
            D.HasKey(D => D.ID);
            D.Property(D => D.Name)
             .IsRequired()
             .HasMaxLength(200)
             .HasColumnName("DepartmentName");
            D.Property(D => D.Ins_ID)
             .IsRequired();
            D.Property(D => D.HiringDate)
             .IsRequired(false)
             .HasDefaultValueSql("GETDATE()");
            D.HasMany(S => S.Students)
             .WithOne(D => D.department)
             .HasForeignKey(D => D.Dep_Id)
             .IsRequired(false); ;
            D.HasMany(I => I.Instructors)
             .WithOne(D => D.department)
             .HasForeignKey(D => D.Dept_ID)
             .IsRequired(false);
            D.HasOne(I => I.instructor)
             .WithOne(D => D.Department)
             .HasForeignKey<Department>(D => D.Ins_ID)
             .OnDelete(DeleteBehavior.Restrict)
             .IsRequired(false);
        }
    }
}
