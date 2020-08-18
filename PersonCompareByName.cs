using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12
{
    class PersonCompareByName : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
