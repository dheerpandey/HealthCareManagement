using Queries.Core.Domain;
using Queries.Core.Repositories;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Queries.Persistence.Repositories
{
    public class AppointmentRepository : Repository<Appointment>, IAppointmentRepository
    {
        public AppointmentRepository(HCMContext context) 
            : base(context)
        {
        }
        //Concrete Implementation for Appointment 
        public HCMContext HCMContext
        {
            get { return Context as HCMContext; }
        }
    }
}