using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queries.Core.Domain
{
    public class Billing
    {
        public Patient Patient { get; set; }
        public double Amount { get; set; }
        public DateTime BillingDate { get; set; }
    }
}
