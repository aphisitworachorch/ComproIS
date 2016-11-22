using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabComproIS_3._1
{
    class Program
    {
        private static void Main(string[] args)
        {
            int choose1 = 0; /* First Variable for Choosing */
            int choose2 = 0; /* Second Variable for Quanitity */
            int total1 = 0; /* Summation for Quantity * Price */

            Console.WriteLine("______WELCOME TO COMPRO CAFE______");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("|Choose [1] Ice Espresso 40 THB  |");
            Console.WriteLine("|Choose [2] Mocca 40 THB         |");
            Console.WriteLine("|Choose [3] Ice Cocoa 35 THB     |");
            Console.WriteLine("|Choose [4] Ice Tea 35 THB       |");
            Console.WriteLine("|Choose [5] Exit                 |");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("__________________________________");

            Console.WriteLine("  ***** Choose Drink Menu *****   ");
            Console.Write("Choose : ");
            int.TryParse(Console.ReadLine(), out choose1);

            if (choose1 == 5 || choose1 == 0)
            {
                Console.WriteLine("Good Bye . You're Exit now !");
            }
            else
            {
                Console.WriteLine("  *****  Enter Quantity   *****   ");
                Console.Write("Choose : ");
                int.TryParse(Console.ReadLine(), out choose2);

                switch (choose1)
            {
                    /* Start of Case */
                case 1: Console.Write("\n");
                        Console.WriteLine("---- Your Drink is Espresso ----"); total1 = choose2 * 40;
                        Console.WriteLine("Total {0} X 40.00 Price is {1:N2}", choose2, total1); break;

                case 2: Console.Write("\n");
                        Console.WriteLine("---- Your Drink is Mocca ----"); total1 = choose2 * 40;
                        Console.WriteLine("Total {0} X 40.00 Price is {1:N2}", choose2, total1); break;

                case 3: Console.Write("\n");
                        Console.WriteLine("---- Your Drink is Ice Cocoa ----"); total1 = choose2 * 35;
                        Console.WriteLine("Total {0} X 35.00 Price is {1:N2}", choose2, total1); break;

                case 4: Console.Write("\n");
                        Console.WriteLine("---- Your Drink is Ice Tea ----"); total1 = choose2 * 35;
                        Console.WriteLine("Total {0} X 35.00 Price is {1:N2}", choose2, total1); break;

                default: break;
                    /* End of Case */

                }
            }

            Console.ReadKey();

        }
    }
}
