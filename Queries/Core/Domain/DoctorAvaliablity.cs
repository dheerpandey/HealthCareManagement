using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queries.Core.Domain
{
    public class DoctorAvaliablity
    {
        public Doctor Doctor { get; set; }
        public string AvalibleDays { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string LeavePlan { get; set; }
    }
}
