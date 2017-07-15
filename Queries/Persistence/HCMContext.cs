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
        
        public virtual DbSet<Appointment> Appointments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AppointmentConfiguration());
        }
    }
}
