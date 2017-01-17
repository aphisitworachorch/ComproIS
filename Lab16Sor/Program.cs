using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16Sor
{
    class Program
    {
        static int SIZE ;
        static int loop1;
        static int loop2;
        static int loop3;
        static int loop4;
        static int col1;
        static int v;
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Enter Number (1-10) : ");
                int.TryParse(Console.ReadLine(), out SIZE);
            } while (SIZE <= 0 || SIZE > 10);

            int[] ns1 = new int[SIZE];

            for (loop1 = 0; loop1 < SIZE; loop1++)
            {
                v++;
                Console.Write("No.{0} : ", v);
                int.TryParse(Console.ReadLine(), out ns1[loop1]);
            }

            Console.Write("Before Sorting : ");
            for (loop1 = 0; loop1 < SIZE; loop1++)
            {
                Console.Write("[ {0} ]", ns1[loop1]);
            }
            for (loop2 = 1; loop2 <= SIZE - 1; loop2++)
            {
                for(loop3 = 0; loop3 <= SIZE - 2; loop3++)
                {
                    if(ns1[loop3] > ns1[loop3+1])
                    {
                        col1 = ns1[loop3];
                        ns1[loop3] = ns1[loop3 + 1];
                        ns1[loop3 + 1] = col1;
                    }
                }
            }

            Console.WriteLine("\n");
            Console.Write("After Sorting : ");
            for (loop1 = 0; loop1 <= SIZE - 1; loop1++)
            {
                Console.Write("[ {0} ]", ns1[loop1]);
            }

            Console.Write("\nOdd Number : ");
            for (loop4 = 0; loop4 < SIZE ; loop4++)
            {
                if (ns1[loop4] % 2 == 1)
            {
                Console.Write("[ {0} ]", ns1[loop4]);
            }
            }
            Console.ReadKey();
        }
    }
}
