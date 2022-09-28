using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task_12
{
    internal class Employee
    {
        static void Main(string[] args)
        {
            emp_det();
        }
        public static void emp_det()
        {
            int empid;
            int n;
            string empname;
            Console.WriteLine("Enter the number of employess:");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter Employee ID: ");
                empid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Employee Name: ");
                empname = Console.ReadLine();
                Employee e = new Employee();
                e.display(empid, empname);
                Console.WriteLine();
            }
        }
        public void display(int empid, string empname)
        {
            Console.WriteLine("Employee Details are: ");
            Console.WriteLine("Employee Id: {empid}");
            Console.WriteLine("Employee name: {empname}");
            
        }
    }
}
