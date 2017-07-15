using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queries.Core.Domain
{
    public class PatientTests
    {
        public Patient Patient { get; set; }
        public Tests Test { get; set; }
        public Doctor Doctor { get; set; }
    }
}
