using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomGenerato
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rNumber = new Random();
            

            Console.WriteLine(rNumber.Next(1, 10));



        }
    }
}
