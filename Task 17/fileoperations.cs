using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Task_17
{
    internal class fileoperations
    {
        public static void Main()
        {
            //move
            /*
            string source = @"C:\Users\ei13072\Documents\C#\fileop.txt";
            string destination = @"C:\Users\ei13072\Documents\C#\File\fileop.txt";
            File.Move(source, destination);
            File.Move(@"C:\Users\ei13072\Documents\C#\fileop.txt", @"C:\Users\ei13072\Documents\C#\File");
            */

            //copy
            /*
            string source_path = @"C:\Users\ei13072\Documents\C#\filemult.txt";
            string dest_path = @"C:\Users\ei13072\Documents\C#\File\filemult.txt";
            File.Copy(source_path, dest_path);
            */

            //delete
            string path = @"C:\Users\ei13072\Documents\C#\file1.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File Exists");
                try
                {
                    File.Delete(path);
                }
                catch
                {
                    Console.WriteLine("Not Happening!");
                }
            }
            else
            {
                Console.WriteLine("File does not Exist");
            }
        }
    }
}
