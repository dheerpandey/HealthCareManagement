using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queries.Core.Domain
{
    public class Appointments
    {
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
        public DateTime AppointmentTime { get; set; }
    }
}
