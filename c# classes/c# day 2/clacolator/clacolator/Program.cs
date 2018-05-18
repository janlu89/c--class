using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clacolator
{
    class Program
    {

        /*static decimal calcolare(decimal n1, decimal n2, string opero)
        {
            switch (opero)
            {
                case "+":
                    decimal total = n1 + n2;
                    return total;
                default:
                    return 0;
                    
            }
        }*/


        static decimal Add(decimal numero1, decimal numero2)
        {
                    decimal totale = numero1 + numero2;
                    return totale;
            }
        static decimal Sottrai(decimal numero1, decimal numero2)
        {
            decimal totale = numero1 - numero2;
            return totale;
        }

        static decimal Moltiplica(decimal numero1, decimal numero2)
        {
            decimal totale = numero1 * numero2;
            return totale;
        }

        static decimal Dividi(decimal numero1, decimal numero2)
        {
            decimal totale = numero1 / numero2;
            return totale;
        }


        static decimal Modulo(decimal numero1, decimal numero2)
        {
            decimal totale = numero1 % numero2;
            return totale;
        }

        static void Main(string[] args)
        {
            string opeIn="";
            decimal number1=0;
            decimal number2=0;

            do
            {
                Console.WriteLine("Hello, this program will exegute simple operatios (+,-,*,/,%)");
                Console.WriteLine("Witch one do you need?");
                opeIn = Console.ReadLine();
                
                if ((opeIn != "+") && (opeIn != "-") && (opeIn != "*") && (opeIn != "/") && (opeIn != "%"))
                {
                    Console.WriteLine("Give me a valid operation");
                }

            } while((opeIn!="+") && (opeIn != "-") && (opeIn != "*") && (opeIn != "/") && (opeIn != "%"));

            string numero;
            do
            {
                Console.Write("Tell me the fist number:");
                numero = Console.ReadLine();
                if(decimal.TryParse(numero, out number1) == false)
                {
                    Console.WriteLine("I need a number pls");
                }
            } while (decimal.TryParse(numero, out number1) == false);

            do
            {
                Console.Write("Tell me the second number:");
                numero = Console.ReadLine();
                if (decimal.TryParse(numero, out number2) == false)
                {
                    Console.WriteLine("I need a number pls");
                }
            } while (decimal.TryParse(numero, out number2) == false);



            switch (opeIn)
            {
                case "+":
                    Console.WriteLine(Add(number1, number2));
                    break;
                case "-":
                    Console.WriteLine(Sottrai(number1, number2));
                    break;
                case "*":
                    Console.WriteLine(Moltiplica(number1, number2));
                    break;
                case "/":
                    Console.WriteLine(Dividi(number1, number2));
                    break;
                case "%":
                    Console.WriteLine(Modulo(number1, number2));
                    break;
                default:
                    Console.WriteLine("???");
                    break;
            }

            

        }
    }
}
