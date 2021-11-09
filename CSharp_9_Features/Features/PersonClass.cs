using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_9_Features.Features
{
    class PersonClass
    {
        public string Name { get; init; }
        public string Surname { get; init; }
    }

    class PersonClass1
    {
        public PersonClass1(string Name, string Surname)
        {
            Name = this.Name;
            Surname = this.Surname;
        }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
