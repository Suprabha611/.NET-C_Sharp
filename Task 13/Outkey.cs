using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Csharp
{
    internal class Outkey
    {
        public static void Main()
        {
            int id;
            string name, dept;
            details(out id, out name, out dept);
            Console.WriteLine($"Student ID= {id}");
            Console.WriteLine($"Student Name= {name}");
            Console.WriteLine($"Student Department= {dept}");

        }
        public static void details(out int sid, out string sname, out string sdept)
        {
            sid = 13072;
            sname = "Suprabha";
            sdept = ".NET";
        }
    }
}
