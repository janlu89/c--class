using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace errorArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeri = new int[3];

            for(int i=0; i<10; i++)
            {
                try
                {
                    numeri[i] = i + 1;
                    Console.WriteLine(numeri[i]);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    break;
                }                
            }
            Console.WriteLine();
            //SECOND PART

            List<string> lista = new List<string> { "1", "2", "3", "4", "5", "6.8", "7", "8" };
            int[] numeri2 = new int[8];

            for(int i=0;i<lista.Count; i++)
            {
                
                try
                {
                    numeri2[i] =  int.Parse(lista[i]);
                    Console.WriteLine(numeri2[i]);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
