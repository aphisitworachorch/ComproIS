using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabComproIS_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, reverse, n1, n2, n3, n4;

            /* Enter Number */
            Console.Write("Enter a number (1000 - 9999): ");
            int.TryParse(Console.ReadLine(), out n);
            /* Receive Number */

            /* First Number (Divided by 1000) Example 2541/1000 = 2.541*/
            n1 = n / 1000;
            /* Second Number (Modulo by 1000 and Divided by 100) Example 2541 Mod 1000 ((2541-2000) 541) = / 100 = 5 */
            n2 = n % 1000 / 100;
            /* Third Number (Modulo by 100 and Divided by 10) Example 2541 Mod 100 ((2541-2500) 41) = / 10 = 41  */
            n3 = n % 100 / 10;
            /* Fourth Number (Modulo by 10) Example 2541 Mod 10 ((2541-2540) 1)*/
            n4 = n % 10;

            /* Throw up all Number by Unmodulo */
            reverse = (n4 * 1000) + (n3 * 100) + (n2 * 10) + n1;

            /* Write Number */
            Console.WriteLine("Reverse number : " + reverse);

            /* Number - Reverse Number (EXAMPLE 2541-1452 = 1089)*/
            Console.WriteLine(n + " - " + reverse + " = " + (n - reverse));

            Console.ReadKey();

        }

            
        }
    }
