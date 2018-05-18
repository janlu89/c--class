using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> libri = new List<string>() {"Libro1","Libro2","Libro3","libro4","libro5","libro6","libro7","libro8", "libro9" };
            string reply = "";

            Console.WriteLine("Do you like edit your book list?[y/n]");
            reply = Console.ReadLine().ToLower();

            /*while (reply != 'n')//asking to add books
            {
                Console.Write("tell me the name of the book that you will like to add: ");
                string nBook = Console.ReadLine();
                libri.Add(nBook);

                Console.WriteLine("Do you like add anther new book to the list?[y/n]");
                reply = Convert.ToChar(Console.ReadLine());
            }*/


            while (reply != "n") 
                    {
                    Console.WriteLine("Do you like to Add, Delete, Dispaly, Search a Book from the list?");
                    reply = Console.ReadLine().ToLower();

                    switch (reply)
                    {
                        case "add":
                            do
                            {
                                Console.Write("Tell me the name of the book that you will like to add: ");
                                string nBook = Console.ReadLine();
                                libri.Add(nBook);
                                Console.WriteLine("Do you like Add others books?[y/n]");
                                reply = Console.ReadLine();
                            } while (reply != "n");
                            break;
                        case "delete":
                            do
                            { 
                            Console.WriteLine("Tell me the name of the book that you will like to delete from the list: ");
                            string nBook = Console.ReadLine();
                            libri.Remove(nBook);
                            Console.WriteLine("Do you like to delete others books?[y/n]");
                            reply = Console.ReadLine();
                            } while (reply != "n") ;
                            break;
                        case "display":
                            libri.ForEach(Console.WriteLine);
                            break;
                        case "search":
                            do
                            { 
                            Console.WriteLine("Tell me the name of the book to search for: ");
                            string nBook = Console.ReadLine().ToLower();
                            bool inList = false;

                                //case insensitive search with LINQ
                                //inList = libri.Any(x => x.Equals(nBook, StringComparison.OrdinalIgnoreCase));   
                                

                                // case insensitive without LINQ
                                foreach (string book in libri)
                                {
                                    if(String.Equals(book, nBook, StringComparison.OrdinalIgnoreCase))
                                    {
                                        inList = true;
                                    }
                                }
                                                                            
                            string risposta = (inList) ? "The Book is in the list" : "The Book is not in the list";
                            Console.WriteLine(risposta);
                            Console.WriteLine("Do you like to search an other book?[y/n]");
                            reply = Console.ReadLine();
                            } while (reply != "n");
                            break;
                        default:
                            Console.WriteLine("ERROR!! Try again");
                            break;                                                  
                    }
                    Console.WriteLine("Do you like to still edit your book list?[y/n]");
                    reply = Console.ReadLine();
                } while (reply != "n");
            


            libri.ForEach(Console.WriteLine);

        }
    }
}
