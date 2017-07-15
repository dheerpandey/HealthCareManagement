using Queries.Core.Repositories;
using System;

namespace Queries.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IAppointmentRepository Appointments { get; }
        int Complete();
    }
}