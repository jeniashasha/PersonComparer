using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12
{
    class PersonCompareByAge : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.Age - y.Age;
        }
    }
}
