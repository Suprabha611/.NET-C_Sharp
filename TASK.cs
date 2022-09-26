using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12
{
    internal class TASK
    {
        public static void Main()
        {
            Conditional();
            TASK c = new TASK();
            c.Looping();
        }
        public void hello()
        {
            string yourName;
            Console.WriteLine("Your name?");
            yourName = Console.ReadLine();
            Console.WriteLine("Hello {0}", yourName);
        }
        public static void Conditional()
        {
            Console.WriteLine("Greatest of 2 numbers");
            int a, b;
            Console.WriteLine("Enter the values:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("A is greater");
            }
            else
            {
                Console.WriteLine("B is greater");
            }
        }
        public void Looping()
        {
            int[] n1 = new int[4] { 1, 2, 5, 6 };
            int[] n2 = new int[5] { 7, 3, 9, 4, 1 };
            int sum = 0;
            for (int i = 0; i < n1.Length; i++)
            {
                Console.WriteLine(n1[i]);
            }
            for (int i = 0; i < n2.Length; i++)
            {
                sum = sum + n2[i];
                
            }
            Console.WriteLine("Sum = {0}",sum);
        }
    }
}
