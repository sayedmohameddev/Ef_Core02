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
    internal class TopicValidations : IEntityTypeConfiguration<Topic>
    {
        public void Configure(EntityTypeBuilder<Topic> T)
        {
            T.HasKey(T => T.ID);
            T.Property(T => T.Name)
             .IsRequired()
             .HasMaxLength(200)
             .HasColumnName("TopicName");
            T.HasMany(C => C.Courses)
             .WithOne(T => T.topic)
             .HasForeignKey(T => T.Top_ID);
        }
    }
}
