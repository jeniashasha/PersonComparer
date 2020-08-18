using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12
{
    class Person : IComparable <Person>
    {
        public int Id { get; private set; }
        public int Age { get; private set; }
        public float Height { get; private set; }
        public string Name { get; private set; }
        static readonly IComparer<Person> _compareById;
        static readonly IComparer<Person> _compareByAge;
        static readonly IComparer<Person> _compareByHeight;
        static readonly IComparer<Person> _compareByName;
        public static IComparer<Person> IDComparer
        {
            get
            {
                return _compareById;
            }
        }
       public static  IComparer<Person> AgeComparer
        {
            get
            {
                return _compareByAge;
            }
        }
        public static IComparer<Person> HeightComparer
        {
            get
            {
                return _compareByHeight;
            }
        }
        public static IComparer<Person> NameComparer
        {
            get
            {
                return _compareByName;
            }
        }
        private static IComparer<Person> DefaultComparer;
        public Person(int id, int age, string name, float height)
        {
            Id = id;
            Age = age;
            Name = name;
            Height = height;
        }
        static Person()
        {
            _compareById = new PersonCompareById();
            _compareByAge = new PersonCompareByAge();
            _compareByHeight = new PersonCompareByHeight();
            _compareByName = new PersonCompareByName();
        }
        public static void ModifyDefaultComparer (IComparer<Person> newComparer)
        {
            DefaultComparer = newComparer;
        }
        public static IComparer<Person> GetDefaultComparer()
        {
            return DefaultComparer;
        }
        public int CompareTo (Person other)
        {
            return this.Id - other.Id;
        }
        public override string ToString()
        {
            return $"Person Name: {Name} ID: {Id} Height: {Height} Age: {Age} ";
        }
    }
}
