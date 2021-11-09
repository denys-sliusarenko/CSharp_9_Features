using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_9_Features.Features
{
    public record PersonRecord(string Name, string Surname); // records is immutable
    // The same:
    /*  public record PersonRecord
      {
          public string Name { get; init; }
          public string Surname { get; init; }

          public PersonRecord(string name, string surname)
          {
              Name = name;
              Surname = surname;
          }
          public void Deconstruct(out string name, out string surname)
          {
              name = Name;
              surname = Surname;
          }
      }*/
}
