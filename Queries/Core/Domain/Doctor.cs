using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queries.Core.Domain
{
    public class Doctor
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Education { get; set; }
        public string Specialization { get; set; }
    }
}
