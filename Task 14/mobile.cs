using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Csharp
{
    internal class mobile
    {
        public static void Main()
        {
            number();
        }
        public static void number()
        {
            Console.WriteLine("Mobile Number validation");
            //string number1 = "990-286-1906";
            //var validate_number1 = Regex.IsMatch(number1, @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$");
            //Console.WriteLine($"Number is: {validate_number1}");
            // string number2 = "690-286-1906";
            //var validate_number2 = Regex.IsMatch(number2, @"^\(?([7-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$");
            //Console.WriteLine($"Number is: {validate_number2}");

                                    /*or*/


            Console.WriteLine("Enter the 10 digit mobile number");
            //string mobile = "(9/8/7)389674670"--> Ture otherwise false
            var number = (Console.ReadLine());
            var validate_number = Regex.IsMatch(number, @"^[789]\d{9}$");
            Console.WriteLine(validate_number);
        }
    }
}
