using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace riddles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] riddle = {"1+1?","Current USA president?" };
            string risposta = "";
            string[] cAnswwer = { "2", "trump" };
            string mError = "Too may errors sorry";
            int error1 = 0;
            int error2 = 0;
            int score = 0;

            Console.WriteLine(riddle[0]);
            risposta = Console.ReadLine();

            while (risposta!= "two"  && risposta !=cAnswwer[0] && error1 < 2 )
            {
                if (error1 > 0)
                {
                    error1++;
                    Console.WriteLine(mError);
                }
                else
                {
                    Console.WriteLine(riddle[0]);
                    risposta = (Console.ReadLine()).ToLower();
                    error1++;
                }
            }

            if (risposta == cAnswwer[0] || risposta == "two")
            {
                score++;
            }

            do
            {
                Console.WriteLine(riddle[1]);
                risposta = (Console.ReadLine()).ToLower();
                error2++;
                if (error2 > 1)
                {
                    Console.WriteLine(mError);
                }

            } while (risposta != cAnswwer[1] && error2<2);

            if (risposta == cAnswwer[1])
            {
                score++;
            }

            Console.WriteLine("Your final score is " + score);
        }
    }
}
