using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_9_Features.Features
{
    public record Person(string Name, string Surname);

    public record PersonEnglish(string Name, string MiddleName, string Surname)
        : Person(Name, Surname);

    public record Teacher(string Name, string Surname, int Grade)
    : Person(Name, Surname);

    public record Student(string Name, string Surname, int Grade)
        : Person(Name, Surname);
}
