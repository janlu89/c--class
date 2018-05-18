using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjectEs1
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 gNumber = 0;//number to guess
            Int32 aNumber = 0;//number to compare
            String sNumber = "";//input number
            Random rNumber = new Random();//generating a random number

            gNumber = rNumber.Next(1, 10);

            do
            {
                Console.WriteLine("Gess the number i'm thinking");

                sNumber = Console.ReadLine();//collecting input

                if ((Int32.TryParse(sNumber, out aNumber) == false))
                {
                    Console.WriteLine("Come on tell me a number");
                }

                else
                {


                    if (aNumber == gNumber)
                    {
                        Console.WriteLine("YOU GET IT!! " + aNumber + " Was the number i was thinking");

                    }
                    else if (aNumber > gNumber)
                    {
                        Console.WriteLine("WRONG NUMBER!! " + aNumber + " Was too big");
                    }
                    else
                    {
                        Console.WriteLine("WRONG NUMBER! " + aNumber + " was too small");

                    }

                }

            } while (aNumber != gNumber);
        }
    }
}
