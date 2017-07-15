using Queries.Persistence;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var unitOfWork = new UnitOfWork(new HCMContext()))
            {

                var appointment = unitOfWork.Appointments.Get(1);
                // Example1
                 
                unitOfWork.Complete();
            }
        }
    }
}
  