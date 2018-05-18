using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom in our quiz game made of 1 question");
            Console.WriteLine("Press enter to start..");

            Console.ReadLine();
            Console.Clear();


            string domanda = "doamnda";
            string[] risposte = { "rispostaA", "rispostaB", "rispostaC", "rispostaD" };

            /*risposte[0] = "rispostaA";
            risposte[1] = "rispostaB";
            risposte[2] = "rispostaC";
            risposte[3] = "rispostaD";*/

            Console.WriteLine(domanda);
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(risposte[i]);
            }
        }
    }
}
