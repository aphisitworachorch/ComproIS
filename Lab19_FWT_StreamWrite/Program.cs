using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Lab19_FWT_StreamWrite
{
    class Program
    {
        struct dat_rec
        {
            public string name;
            public string stdid;
            public string gpax_sel;
        };

        static string line;
        static int cnt;
        static void Main(string[] args)
        {
            dat_rec info = new dat_rec();
            do
            {
                Console.Write("Enter Student ID : ");
                info.stdid = Console.ReadLine();

                Console.Write("Enter Student Name : ");
                info.name = Console.ReadLine();

                Console.Write("Enter GPAX (A,B,C,D,F) : ");
                info.gpax_sel = Console.ReadLine();

                if (info.gpax_sel.Length > 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid GPAX Selection ! ");
                }

            } while (info.gpax_sel.Length > 1);

            try
            {
                StreamWriter write_x = new StreamWriter("C:\\TC\\student.txt", true);
                write_x.WriteLine("{0,-10} {1,-10} {2,-10}", info.stdid, info.name, info.gpax_sel);
                write_x.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception : {0}", e.Message);
            }
            try
            {
                StreamReader read_x = new StreamReader("C:\\TC\\student.txt");
                line = read_x.ReadLine();
                
                while ((line = read_x.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    cnt++;
                }
                read_x.Close();

                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception {0} ", e.Message);
                {

                }
            }
            Console.WriteLine("{0} record(s)read ", cnt);

            Console.ReadKey();
        }
    }
}
