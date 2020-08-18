using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12
{
    class PersonCompareById : IComparer<Person>
    {
        public int Compare (Person x, Person y)
        {
            return x.Id - y.Id;
        }
    }
}
