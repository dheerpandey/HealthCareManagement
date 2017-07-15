using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queries.Core.Domain
{
    public class PatientVisits
    {
        public Patient Patient { get; set; }
        public DateTime VisitDate { get; set; }
    }
}
