using System;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp12
{
    class Program
    {
        static void PrintPersonArray(Person[] people)
        {
            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }
        }
        
        static void Main(string[] args)
        {
            Person[] people =
             {
                new Person (5, 15, "Harry", 1.85f),
                new Person (4, 90, "Jessica", 1.65f),
                new Person (2, 88, "Charles", 1.55f),
                new Person (1, 25, "Christine", 1.80f),
                new Person (7, 40, "Dudi", 1.67f)
            };

            Console.WriteLine("Compare by id");
            Array.Sort(people);
            PrintPersonArray(people);
            Console.WriteLine("Compare by name");
            Array.Sort(people, new PersonCompareByName());
            PrintPersonArray(people);
            Console.WriteLine("Compare by age");
            Array.Sort(people, new PersonCompareByAge());
            PrintPersonArray(people);
            Console.WriteLine("Compare by height");
            Array.Sort(people, new PersonCompareByHeight());
            PrintPersonArray(people);
            
        }
    }
}
