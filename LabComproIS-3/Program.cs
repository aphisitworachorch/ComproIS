using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabComproIS_3
{
    class Program
    {
        static void Main(string[] args)
        {
            float grade1;

            Console.Write("Your score input : ");
            float.TryParse(Console.ReadLine(), out grade1);

                if (grade1 >= 80)
                {
                    Console.WriteLine("Your grade is : A");
                }
                else if (grade1 >= 70)
                {
                    Console.WriteLine("Your grade is : B");
                }
                else if (grade1 >= 60)
                {
                    Console.WriteLine("Your grade is : C");
                }
                else if (grade1 >= 50)
                {
                    Console.WriteLine("Your grade is : D");
                }
                else if (grade1 >= 0)
                {
                    Console.WriteLine("Your grade is : F");
                }
                else if (grade1 >= 100 && grade1 > 101)
                {
                    Console.WriteLine("Oh my god !!! O_O Error !!! Error !!!");
                }
                else
                {
                Console.WriteLine("What the heck !");
                }

                Console.ReadKey();

         }         
    }
}
