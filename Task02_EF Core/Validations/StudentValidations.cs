using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Task01.Entities;

namespace Task01_.Validations
{
    internal class StudentValidations : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> S)
        {
            S.HasKey(S => S.ID);
            S.Property(S => S.FName)
             .HasColumnType("VARCHAR")
             .HasMaxLength(50)
             .IsRequired()
             .HasColumnName("Fname");
            S.Property(S => S.LName)
             .HasColumnType("VARCHAR")
             .HasMaxLength(50)
             .IsRequired()
             .HasColumnName("LName");
            S.Property(S => S.Address)
             .HasColumnName("address")
             .IsRequired()
             .HasMaxLength(50)
             .HasColumnType("NVARCHAR");
            S.Property(S => S.Age)
             .IsRequired(false);
            S.Property(S => S.Dep_Id)
             .IsRequired();
        }
    }
}

