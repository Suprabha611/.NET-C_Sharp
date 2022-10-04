using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Task_18
{
    internal class hashanddict
    {
        static public void Main()
        {
            //dictionary
            Dictionary<int, string> d = new Dictionary<int, string>();

            d.Add(1, "Suprabha");
            d.Add(2, "Meghana");
            d.Add(3, "Sushmitha");

            //hastable
            Hashtable h = new Hashtable();

            h.Add(1, ".NET");
            h.Add(2, ".NET");
            h.Add(3, "Database");

            foreach (KeyValuePair<int, string> element in d)
            {
                Console.WriteLine("ID: {0} and Name: {1}", element.Key, element.Value);
            }
            Console.WriteLine("\n");
            foreach (DictionaryEntry element in h)
            {
                Console.WriteLine("ID: {0} and Batch: {1}", element.Key, element.Value);
            }
        }
    }
}