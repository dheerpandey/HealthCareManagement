using Queries.Core;
using Queries.Core.Repositories;
using Queries.Persistence.Repositories;

namespace Queries.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly HCMContext _context;

        public UnitOfWork(HCMContext context)
        {
            _context = context;
            Appointments = new AppointmentRepository(_context);
        }

        public IAppointmentRepository Appointments { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}