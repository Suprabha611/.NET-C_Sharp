using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Task_17
{
    internal class countline
    {
        public static void Main(string[] args)
        {
            int counter = 0;
            foreach (string line in File.ReadLines(@"C:\Users\ei13072\Documents\C#\File\fileop.txt"))
            {
                Console.WriteLine(line);
                counter++;
            }
            Console.WriteLine("There are {0} lines", counter);
        }
    }
}
