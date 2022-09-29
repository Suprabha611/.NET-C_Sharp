using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Csharp.Task_14
{
        public class Bonus
        {
            protected int bonus;
        }
        public class Staff : Bonus
        {
            protected int salary = 25000;
            public void Staff_bonus()
            {
                bonus = 3 * salary;
                Console.WriteLine($"Staff salary: {salary} and Bonus= { bonus}");
            }
        }
        public class NonStaff : Staff
        {
            protected int salary = 15000;
            public void NonStaff_bonus()
            {
                bonus = 2 * salary;
                Console.WriteLine($"Non Staff Salary: {salary} and Bonus= {bonus}");
            }
        }
    internal class inheritance
    {
        class Program
        {
            public static void Main()
            {
                Staff s = new Staff();
                s.Staff_bonus();
                NonStaff n = new NonStaff();
                n.NonStaff_bonus();
            }
        }
    }
}