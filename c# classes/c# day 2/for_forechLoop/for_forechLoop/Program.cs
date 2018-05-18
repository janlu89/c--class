using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_forechLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sevenDwarves = { "Happy", "Doc", "Sleepy","Sneezy", "Dopey", "Bashful", "Grumpy"};

            for(int i=0; i<sevenDwarves.Length; i++)
            {
                Console.WriteLine("Here's your dinner, "+sevenDwarves[i]);
            }

            foreach(string nano in sevenDwarves)
            {
                Console.WriteLine("Here's your drink, "+nano);
            }
            Console.WriteLine();

            string[] dinnerC = new string[7] ;
            string[] drinkC = new string[7];
            int t = 0;

            foreach(string dwafn in sevenDwarves)
            {
                Console.WriteLine("Hi "+dwafn+" what do you want for dinner?");               
                dinnerC[t] = Console.ReadLine();
                Console.WriteLine("and for drink, "+dwafn+"?");
                drinkC[t] = Console.ReadLine();
                t++;
            }

            for (t = 0; t < drinkC.Length; t++)
            {
                if (drinkC[t] != "" && drinkC[t] != "nothing")
                {
                    Console.WriteLine(sevenDwarves[t] + ", your " + drinkC[t] + " is here");
                }
            }

            for (t=0; t<dinnerC.Length; t++)
            {
                if (dinnerC[t] != "" && dinnerC[t]!="nothing")
                {
                    Console.WriteLine(sevenDwarves[t] + ", your " + dinnerC[t] + " is ready");
                }
            }
        }
    }
}
