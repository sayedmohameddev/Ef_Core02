using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Task01.Entities;

namespace Task01_.Validations
{
    internal class Stud_CourseValidations : IEntityTypeConfiguration<Stud_Course>
    {
        public void Configure(EntityTypeBuilder<Stud_Course> SC)
        {
            SC.Property(SC => SC.Grade)
              .IsRequired(false)
              .HasColumnType("float");
            SC.HasKey(sc => new { sc.StudentID, sc.CourseID });
        }
    }
}
