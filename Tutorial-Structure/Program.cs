using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_Structure
{
    class Program
    {
        struct bank
        {
            public int thousandbank;
            public int f_hundredbank;
            public int hundredbank;
        }

        struct record
        {
            public string name;
            public string password;
        }
        static int i1, i2;
        static int bank_i;
        static void Main(string[] args)
        {
            bank[] bank = new bank[1];

            Console.WriteLine("Welcome to Som-O Bank");
            for (i1 = 0; i1 < bank.Length; i1++)
            {
                Console.Write("Enter [1000] Bank Value : ");
                int.TryParse(Console.ReadLine(), out bank[i1].thousandbank);
                Console.Write("Enter [500] Bank Value : ");
                int.TryParse(Console.ReadLine(), out bank[i1].f_hundredbank);
                Console.Write("Enter [100] Bank Value : ");
                int.TryParse(Console.ReadLine(), out bank[i1].hundredbank);
            }

            record[] cust = new record[3];
            for (i2 = 0; i2 < cust.Length; i2++)
            {
                do
                {
                    Console.Write("Enter Name : ");
                    cust[i2].name = Console.ReadLine();
                    PASS:
                    Console.Write("Enter Password : ");
                    cust[i2].password = Console.ReadLine();
                    if (cust[i2].password.Length > 4)
                    {
                        Console.WriteLine("Invalid Password");
                        goto PASS;
                    }
                } while (cust[i2].password.Length > 4);
            }

            for (i1 = 0; i1 < 3; i1++)
            {
                Console.WriteLine("{0} Password is {1}", cust[i1].name, cust[i1].password);
            }

            for (i1 = 0; i1 < 3; i1++)
            {
                Console.WriteLine("Withdraw Money : ");
                int.TryParse(Console.ReadLine(), out bank_i);

                if (bank[i1].thousandbank == bank_i)
                {
                    Console.WriteLine("Successfull Withdraw 1000 Notes for {0}", bank[i1].thousandbank);
                } else if (bank[i1].f_hundredbank == bank_i) {
                    Console.WriteLine("Successfull Withdraw 500 Notes for {0}", bank[i1].f_hundredbank);
                } else if (bank[i1].hundredbank == bank_i) {
                    Console.WriteLine("Successfull Withdraw 100 Notes for {0}", bank[i1].hundredbank);
                }  else if (bank[i1].thousandbank != bank_i || bank[i1].f_hundredbank != bank_i || bank[i1].hundredbank != bank_i) {
                            Console.WriteLine("No more notes ! ");
                        }

                    }
                    Console.ReadKey();
                }

            }
        }