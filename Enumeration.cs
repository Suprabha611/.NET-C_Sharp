using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Task_12
{
    internal class Enumeration
    {
        enum training
        {
            DotNet_FullStack,
            HTML=0,
            CSS=1,
            BOOTSTRAP,
            JS,
            ANGULAR,
            CSharp=6
        }
        public static void Main()
        {
            Console.WriteLine(training.DotNet_FullStack);
            training task = training.JS;
            Console.WriteLine(task);
            Console.WriteLine(training.BOOTSTRAP);
            int num1 = (int)training.BOOTSTRAP;
            Console.WriteLine(num1);
            Console.WriteLine(training.CSharp);
            int num2 = (int)training.CSharp;
            Console.WriteLine(num2);
        }
    }
}