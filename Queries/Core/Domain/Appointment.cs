using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queries.Core.Domain
{
    public class Appointment
    {
        public int Id { get; set; }
        //public Patient Patient { get; set; }
        public DateTime AppointmentTime { get; set; }

        public Appointment()
        {
            Doctors = new HashSet<Doctor>();
        }
        public virtual ICollection<Doctor> Doctors { get; set; }
    }
}
