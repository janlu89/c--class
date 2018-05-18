using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avarageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("How many number do you have?");
            int v = int.Parse(Console.ReadLine());

            decimal[] numbers = new decimal[v];*/
            int t = 1;
            decimal[,] numbers = new decimal[4,5];

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    
                        Console.WriteLine("Tell me the nr." + t + " of the list");
                    numbers[i, j] = decimal.Parse(Console.ReadLine());
                    t += 1;
                }
            }

            decimal resultT = 0;

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                Console.WriteLine();
                decimal result = 0;
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    result += numbers[i, j];
                    resultT += numbers[i, j];
                    Console.Write("  "+numbers[i,j]+" ");
                }
                Console.WriteLine("The result of the row "+(i+1)+" is "+result);
            }

            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                decimal result = 0;
                for (int i = 0; i < numbers.GetLength(0); i++)
                {
                    result += numbers[i, j];
                }
                Console.WriteLine("The result of the column " + (j + 1) + " is " + result);
            }

            Console.WriteLine("the average of the number that you told me is: {0} and the total is {1}",  resultT / numbers.Length,resultT);


        }
    }
}
