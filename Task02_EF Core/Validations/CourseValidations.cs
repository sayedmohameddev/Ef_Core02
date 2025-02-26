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
    internal class CourseValidations : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> C)
        {

            C.HasKey(C => C.ID);
            C.Property(C => C.Name)
             .HasColumnName("Name")
             .IsRequired()
             .HasColumnType("VARCHAR")
             .HasMaxLength(50);
            C.Property(C => C.Description)
            .HasColumnName("Description")
            .IsRequired(false)
            .HasColumnType("VARCHAR")
            .HasMaxLength(300);
            C.Property(C => C.Duration)
             .IsRequired(true);
            C.Property(C => C.Top_ID)
             .IsRequired(true);

        }
    }
}
