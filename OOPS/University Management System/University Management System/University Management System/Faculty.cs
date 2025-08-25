using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_System
{
    class Faculty:Person
    {
        public override string Id { get; set; }
        public override string Name { get; set; }
        public string Subject { get; set; }
        public string Department { get; set; }

    }
}
