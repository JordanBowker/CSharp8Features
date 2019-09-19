using System;

namespace CSharp8Features
{
    public class NullCoalescingAssignment
    {
        // Null-coalescing assignment operator ??=
        // Assign right hand value to left hand variable, if left hand variable is null

        public void OldWay(string name)
        {
            if (name == null) name = "John Cena";

            Console.WriteLine($"We all love {name}");
        }

        public void NewWay(string name)
        {
            name ??= "John Cena";

            Console.WriteLine($"We all love {name}");
        }
    }
}
