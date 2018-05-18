using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//to read the files

namespace errorsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = null;
            try
            {
                sr = File.OpenText(@"C:\Users\Student\Desktop\myData.txt");
                Console.WriteLine(sr.ReadToEnd());
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("not found");
            }
            finally
            {
                Console.WriteLine();
            }



        }
    }
}
