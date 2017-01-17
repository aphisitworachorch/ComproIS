using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17Sort_NAME
{
    class Program
    {
        static int SIZE;
        static int loop1;
        static int loop2;
        static int loop3;
        static int i;
        static string clt1;
        static void Main(string[] args)
        {
            do
            {
                Console.Write("How Many Numbers (1-10) : ");
                int.TryParse(Console.ReadLine(), out SIZE);
            } while (SIZE <= 0 || SIZE > 10);

            string[] stdid = new string[SIZE];

            for (loop1 = 0; loop1 < stdid.Length; loop1++)
            {
            X:
                Console.Write("Student ID {0} : ", i++);
                stdid[loop1] = Console.ReadLine();
                
                if (stdid[loop1].Length < 8 || stdid[loop1].Length > 8)
                {
                    i--;
                    Console.WriteLine("Invalid Student ID , Please Enter 8 Characters.");
                    goto X;
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Before Sorting ...");
            for (loop1 = 0; loop1 < stdid.Length; loop1++)
            {
                Console.WriteLine("Student ID {0} = {1} ", loop1, stdid[loop1]);
            }
            Console.ReadKey();
            for (loop2 = 1; loop2 <= stdid.Length - 1; loop2++)
            {
                for(loop3 = 0; loop3 <= stdid.Length -2; loop3++)
                {
                    if(string.Compare(stdid[loop3], stdid[loop3 + 1], true) > 0)
                    {
                        clt1 = stdid[loop3];
                        stdid[loop3] = stdid[loop3 + 1];
                        stdid[loop3 + 1] = clt1;
                    }
                }
            }
            Console.WriteLine("");
            Console.WriteLine("After Sorting ...");
            for (loop1 = 0; loop1 < stdid.Length; loop1++)
            {
                Console.WriteLine("Student ID {0} = {1} ", loop1 , stdid[loop1]);
            }
            Console.ReadKey();
        }
        
        
        }
    }
