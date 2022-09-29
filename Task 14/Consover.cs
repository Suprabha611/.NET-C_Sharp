using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Task_14
{
        public class add
        {
            public add(int a, int b)
            {
                Console.WriteLine($"Output in int: {a + b}");
            }
            public add(float a, float b)
            {
                Console.WriteLine($"Output in float: {a + b}");
            }
            public add(string a, string b)
            {
                Console.WriteLine($"Output in string: {a + b}");
            }
        }
        internal class Const_overload
        {
            public static void Main()
            {
                add ad = new add(6, 8);
                add ad1 = new add(7.88f, 4.99f);
                add ad2 = new add("DOT", "NET");
            }
        }
}
