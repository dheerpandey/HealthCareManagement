﻿using Queries.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Queries.Persistence.EntityConfigurations
{
    public class AppointmentConfiguration : EntityTypeConfiguration<Appointment>
    {
        public AppointmentConfiguration()
        {
            //Property(c => c.Description)
            //    .IsRequired()
            //    .HasMaxLength(2000);

            //Property(c => c.Name)
            //    .IsRequired()
            //    .HasMaxLength(255);

            //HasRequired(c => c.Author)
            //    .WithMany(a => a.Courses)
            //    .HasForeignKey(c => c.AuthorId)
            //    .WillCascadeOnDelete(false);

            //HasRequired(c => c.Cover)
            //    .WithRequiredPrincipal(c => c.Course);

            //HasMany(c => c.Tags)
            //    .WithMany(t => t.Courses)
            //    .Map(m =>
            //    {
            //        m.ToTable("CourseTags");
            //        m.MapLeftKey("CourseId");
            //        m.MapRightKey("TagId");
            //    });
        }
    }
}