using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace SortingID_File
{
    class Program
    {
        struct student_record
        {
            public string student_id;
            public string student_name;
            public double student_GPA;
        };
        const int _SIZE = 3;

        // Loop //
        static int loop1, loop2, loop3;
        // Hold Part //
        static string HL , HL2;
        static double HL3;

        // Verify Part //
        static string _VE1_string;
        static string _VE2_string;
        static double _VE3_double;
        static int _VX_sel;

        static void Main(string[] args)
        {
            // Array Declarations //
            student_record[] record_p1 = new student_record[_SIZE];

            // Do-While Functions for Collect [student_record] Data Structures //
            Console.WriteLine("Hello , I'm Assistant of Teacher on 90's ");
            for (loop1 = 0; loop1 < _SIZE; loop1++)
            {
                    X:
                    // Counting For Greetings or Re-Greeting //
                    Console.WriteLine("Enter Information of {0} Student", loop1 + 1);
                    Console.WriteLine();

                    // Record Section //
                    Console.Write("Enter Student ID : ");
                    record_p1[loop1].student_id = Console.ReadLine();
                    _VE1_string = record_p1[loop1].student_id;

                    Console.Write("Enter Student Name : ");
                    record_p1[loop1].student_name = Console.ReadLine();
                    _VE2_string = record_p1[loop1].student_name;

                    Console.Write("Enter {0} GPAX : ", record_p1[loop1].student_name);
                    double.TryParse(Console.ReadLine(), out record_p1[loop1].student_GPA);
                    _VE3_double = record_p1[loop1].student_GPA;

                    if (_VE1_string.Length > 8 || _VE1_string.Length < 8 || _VE2_string.Length < 1 || _VE3_double > 4.00 || _VE3_double < 0.00)
                    {
                        Console.WriteLine("Invalid Information on [{0}]", loop1);
                        Console.WriteLine("Enter New Information ! ");
                        goto X;
                    }

            }

            // Sorting Information ! // 

            do
            {
                Console.WriteLine("What's sorting Type did you favor ?");
                Console.WriteLine("1. Student ID First");
                Console.WriteLine("2. GPAX First");
                Console.WriteLine("3. Name First");
                Console.Write("Select : ");
                int.TryParse(Console.ReadLine(), out _VX_sel);
            } while (_VX_sel < 0 || _VX_sel > 3);

            for (loop2 = 1; loop2 < _SIZE - 1;loop2++)
            {
                for (loop3 = 0; loop3 < _SIZE -2; loop3++)
                {
                    if (string.Compare(record_p1[loop3].student_name , record_p1[loop3+1].student_name , true) > 0 )
                    {

                        if (_VX_sel == 1)
                        { 

                            HL3 = record_p1[loop3].student_GPA;
                            record_p1[loop3].student_GPA = record_p1[loop3 + 1].student_GPA;
                            record_p1[loop3 + 1].student_GPA = HL3;

                            HL = record_p1[loop3].student_name;
                            record_p1[loop3].student_name = record_p1[loop3 + 1].student_name;
                            record_p1[loop3 + 1].student_name = HL;

                            HL2 = record_p1[loop3].student_id;
                            record_p1[loop3].student_id = record_p1[loop3 + 1].student_id;
                            record_p1[loop3 + 1].student_id = HL2;

                        } else if (_VX_sel == 2)
                        {

                            HL = record_p1[loop3].student_name;
                            record_p1[loop3].student_name = record_p1[loop3 + 1].student_name;
                            record_p1[loop3 + 1].student_name = HL;

                            HL2 = record_p1[loop3].student_id;
                            record_p1[loop3].student_id = record_p1[loop3 + 1].student_id;
                            record_p1[loop3 + 1].student_id = HL2;

                            HL3 = record_p1[loop3].student_GPA;
                            record_p1[loop3].student_GPA = record_p1[loop3 + 1].student_GPA;
                            record_p1[loop3 + 1].student_GPA = HL3;

                        } else if (_VX_sel == 3)
                        {

                            HL2 = record_p1[loop3].student_id;
                            record_p1[loop3].student_id = record_p1[loop3 + 1].student_id;
                            record_p1[loop3 + 1].student_id = HL2;

                            HL3 = record_p1[loop3].student_GPA;
                            record_p1[loop3].student_GPA = record_p1[loop3 + 1].student_GPA;
                            record_p1[loop3 + 1].student_GPA = HL3;

                            HL = record_p1[loop3].student_name;
                            record_p1[loop3].student_name = record_p1[loop3 + 1].student_name;
                            record_p1[loop3 + 1].student_name = HL;

                        }
                    }
                }
            }

            for (loop1 = 0; loop1 < _SIZE; loop1++)
            {
                // Record Section //
                Console.WriteLine();
                Console.WriteLine("Student {0} ID : {1}" , record_p1[loop1].student_name , record_p1[loop1].student_id);
                Console.WriteLine("GPAX of {0} is : {1}", record_p1[loop1].student_name , record_p1[loop1].student_GPA);
            }

            Console.ReadKey();

            Console.Clear();

            string stdfile;
            Console.Write("Enter File Name : ");
            stdfile = Console.ReadLine();

            try
            {
                for (loop1 = 0; loop1 < _SIZE; loop1++)
                {
                    StreamWriter _Fx = new StreamWriter("C:\\_data\\" + stdfile + ".txt", true);
                    _Fx.WriteLine("Student {0} ID : {1}", record_p1[loop1].student_name, record_p1[loop1].student_id);
                    _Fx.WriteLine("GPAX of {0} is : {1}", record_p1[loop1].student_name, record_p1[loop1].student_GPA);

                    _Fx.Close();
                }

            }
            catch (Exception e) {
                Console.WriteLine("Error" + e.Message);
            }

            Console.ReadKey();
        }
    }
}
