using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_System
{
    class InvalidAgeException:Exception
    {
        public InvalidAgeException(string err):base(err){  }
    }

    class InvalidMarkException : Exception
    {
        public InvalidMarkException(string err) : base(err) { }
    }

}
