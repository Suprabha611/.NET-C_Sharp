using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Csharp.Task_15
{
   /*public class valage
    {
        static void checkAge(int age)
        {
            if (age < 22)
            {
                throw new ArithmeticException("Access denied -You must be atleast 22 years old.");
            }
            else
            {
                Console.WriteLine("Go ahead!!");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the age: ");
            var age = Convert.ToInt32(Console.ReadLine());
            checkAge(age);
        }
    }*/

                            /*or*/

     public class InvalidAgeException : Exception
     {
         public InvalidAgeException(String message): base(message)
         {
         }
     }
     public class TestUserDefinedException
     {
         static void validate(int age)
         {
             if (age < 22)
             {
                 throw new InvalidAgeException("Access denied!! - You must be atleast 22 years old.");
             }
             else
             {
                 Console.WriteLine("Go ahead!!");
             }
         }
         public static void Main(string[] args)
         {
             try
             {
                 Console.WriteLine("Enter the age");
                 var age = Convert.ToInt32(Console.ReadLine());
                 validate(age);
             }
             catch (InvalidAgeException e)
             {
                 Console.WriteLine(e);
                 
             }
         }
     }
}
