using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex36_ObserverPattern
{
    public class Teacher : Person
    {
        public Teacher(string name) : base(name)
        {
        }

        public string JobTitle { get; set; }
    }
}
