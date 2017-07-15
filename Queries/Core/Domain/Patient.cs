using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queries.Core.Domain
{
    public class Patient
    {
        public string Name { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public long ContactNum { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        public long EmergenctContactNum { get; set; }
        public string EmergencyContactName { get; set; }
    }
}
