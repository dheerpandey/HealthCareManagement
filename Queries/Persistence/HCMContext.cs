using Queries.Core.Domain;
using Queries.Persistence.EntityConfigurations;
using System.Data.Entity;

namespace Queries.Persistence
{
    public class HCMContext : DbContext
    {
        public HCMContext()
            : base("name=HCMContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CourseConfiguration());
        }
    }
}
