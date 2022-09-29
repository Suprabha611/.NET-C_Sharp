using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Task_14
{
    public class Internal
    {
        public string ename;

        public void std_details(string name)
        {
            ename = name;
            Console.WriteLine($"{ename}");
        }
    }
    public class Internal_public
    {
        public static void Main()
        {
            Internal inter = new Internal();
            inter.std_details("Suprabha");
        }
    }
}
