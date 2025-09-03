using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    [AttributeUsage(AttributeTargets.Class|AttributeTargets.Method|AttributeTargets.Property)]
    class PersonAttribute:Attribute
    {
        public string Name { get;}
        public int Id { get; set; } 
        public PersonAttribute(string name)
        {
            Name = name;
        }
    }

    [PersonAttribute("Sukant", Id =1)]
    class Project
    {
        [PersonAttribute("VJ", Id =2)]
        public static void DoWork()
        {
            Console.WriteLine("Work in Progress...");
        }
    }
}
