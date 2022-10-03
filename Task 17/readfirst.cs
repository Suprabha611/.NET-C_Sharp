using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Task_17
{
    public class readfirst
    {
        public static void Main()
        {
            string[] content;
            content = File.ReadAllLines(@"C:\Users\ei13072\Documents\C#\File\fileop.txt");
            Console.WriteLine(content[0]);
        }
    }
}
