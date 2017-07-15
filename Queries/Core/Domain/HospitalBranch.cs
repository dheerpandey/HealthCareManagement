using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queries.Core.Domain
{
    public class HospitalBranch
    {
        public Hospital Hospital { get; set; }
        public Branch Branch { get; set; }
    }
}
