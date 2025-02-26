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
    internal class InstructorValidations : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> I)
        {
            I.HasKey(I => I.ID);
            I.Property(I => I.Name)
             .IsRequired()
             .HasMaxLength(200)
             .HasColumnName("InstructorName");
            I.Property(I => I.Bonus)
             .HasColumnType("money");
            I.Property(I => I.Salary)
             .HasColumnType("money");
            I.Property(I => I.HourRate)
             .HasColumnType("money");
            I.Property(I => I.Address)
             .HasColumnName("address")
             .HasMaxLength(200);
            I.Property(I => I.Dept_ID)
             .IsRequired(false);
        }
    }
}
