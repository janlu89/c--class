using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace presidentUSA
{
    class Program
    {
        static void Main(string[] args)
        {
            string replyV = "";

            Console.WriteLine("Several people stood for the Presidency of USA in 2016. Who should win according to you?");

            string[] presidenti = {"Trump", "Clinton", "Sanders", "Bush"};

            for(int i=0; i<4; i++)
            {
                Console.WriteLine(presidenti[i]);
            }

            string opinionP = (Console.ReadLine()).ToLower();

            switch (opinionP)
            {
                case "trump":
                case "donald":
                    replyV= "Start to collect the bricks for the wall";
                    break;

                case "clinton":
                case "hilary":
                case "hilary clinton":         
                    replyV = "This time she will put the face";
                    break;

                case "sanders":
                    replyV = "More taxes for everybody";
                    break;

                case "bush":
                case "jeb":
                    replyV = "Really?";
                    break;

                default:
                    replyV = "Best choice";
                    break;                              
            }



            Console.WriteLine(replyV);
        }
    }
}
