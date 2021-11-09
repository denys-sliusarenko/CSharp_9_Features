using CSharp_9_Features.Features;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;

namespace CSharp_9_Features
{
    class Program
    {
        static void Main(string[] args)
        {

            var person = new PersonClass() { Name = "Silver", Surname = "Chariot" };

            // person.Name = "Hermit"; Error

            Console.WriteLine("compare records by value");
            // compare records by value
            var first = new PersonRecord("Hermit", "Purple");
            var second = new PersonRecord("Hermit", "Purple");
            Console.WriteLine(first.Equals(second)); // True
            Console.WriteLine(first == second); // True
            Console.WriteLine(first != second); // False

            Console.WriteLine();

            Console.WriteLine("ovverided ToString() in records");

            // ovverided ToString() in records
            var personRecord = new PersonRecord("Moody", "Blues");
            var personStruct = new PersonStruct("Moody", "Blues");
            var personClass = new PersonClass1("Moody", "Blues");

            Console.WriteLine(personRecord.ToString()); //PersonRecord { Name = Moody, Surname = Blues }
            Console.WriteLine(personStruct.ToString()); //PersonStruct
            Console.WriteLine(personClass.ToString());  //PersonClass


            Console.WriteLine();
            Console.WriteLine("Inherit records");

            // Inherit records
            var personRec = new Person("Tom", "Twain");
            var englishPerson = new PersonEnglish("Tom", "Finn", "Twain");

            Console.WriteLine(englishPerson);
            //PersonEnglish { Name = Tom, Surname = Twain, MiddleName = Finn }

            var (one, two, three) = englishPerson;
            Console.WriteLine(one + " " + two + " " + three);
            //Tom Finn Twain

            Console.WriteLine();
            Console.WriteLine("compare inherited records by value");
            //
            Person teacher = new Teacher("Tom", "Twain", 3);
            Person student = new Student("Tom", "Twain", 3);
            Console.WriteLine(teacher == student);
            //false
            Student student2 = new Student("Tom", "Twain", 3);
            Console.WriteLine(student2 == student);
            //true


            Console.WriteLine();
            Console.WriteLine("use 'with'");
            var person1 = new Person("Tom", "Twain");
            var another = person1 with { Name = "Finn" };

            Console.WriteLine(another);
            //Person { Name = Finn, Surname = Twain } 

            var another2 = another with { };
            Console.WriteLine(another == another2);
            //true

            Console.WriteLine();

            Console.WriteLine("target typing");
            ObservableCollection<string> collection = new(); //without "new ObservableCollection<string>();"
            Person person2 = new("Hermit", "Purple");//without "new Person("Hermit", "Purple");"

            //error
            //var collection = new();


            var collection1 = new ObservableCollection<string>();
            // the same
            // ObservableCollection<string> collection1 = new();

            Console.WriteLine();
            Console.WriteLine("operators ?? и ?");
            // operators ?? и ?
            Person person44 = 1 > 0 ? student : teacher;

            Person person33 = teacher ?? null;// work with null


            // foreach support GetEnumerator
            Console.WriteLine();
            Console.WriteLine("foreach support GetEnumerator");
            foreach (var item in (1, 2, 3, 4))
            {
                 Console.WriteLine(item);
            }

            Console.WriteLine("support Range:  var i in 1..5");
            foreach (var i in 1..5)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine();
            Console.WriteLine("attributes local methodsb");

            PrintDebug();



            //Delay
            Console.ReadKey();
        }

        [Conditional("DEBUG")]
        static void PrintDebug()
        {
            Console.WriteLine("This is debug mode");
        }

    }
}
