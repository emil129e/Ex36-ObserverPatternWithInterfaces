using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex36_ObserverPattern
{
    public class Organization
    {
        private readonly string _name;
        public string Name
        {
            get { return _name; }     
        }
        public string _address;
        public string Address { get; set; }
        public Organization(string name)
        {
            _name = name;
        }
    }
}
