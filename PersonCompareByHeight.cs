using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12
{
    class PersonCompareByHeight : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            if(x.Height>y.Height)
            {
                return 1;
            }
            if(x.Height == y.Height)
            {
                return 0;

            }
            return -1;
        }
    }
}
