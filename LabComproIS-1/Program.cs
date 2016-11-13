using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabComproIS_1
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Describe for Variable Receive */


            /* Describe for Variable Receive */
            Console.Write("Please Insert Your name :");
            string name1 = Console.ReadLine();
            /* Describe for Variable Receive */

            /* Describe for Variable Receive */
            Console.Write("Your Student ID : ");
            string sid1 = Console.ReadLine();
            /* Describe for Variable Receive */

            /* Describe for Variable Receive */
            Console.Write("Your Age : ");
            int age;
            int.TryParse(Console.ReadLine(), out age);
            /* Describe for Variable Receive */

            /* Describe for Variable Receive */
            Console.Write("Your GPAX : ");
            double GPAX;
            double.TryParse(Console.ReadLine(), out GPAX);
            /* Describe for Variable Receive */

            /* Describe for Variable Receive */
            Console.Write("Grade (A,B,C,D,F,W) : ");
            string gx = Console.ReadLine();
            /* Describe for Variable Receive */

            Console.WriteLine("Hi , {0}, your ID is {1} , You are {2} years old , and your GPA is {3} \n", name1 , sid1 , age , GPAX);
            Console.WriteLine("You will get grade '{0}' as you expected", gx);

            Console.ReadKey();

        }
    }
}
