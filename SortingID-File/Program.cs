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
        };

        struct subject_structure
        {
            public string subject;
            public double student_GPA;
            public double stdsub_weight;
            public double finishgpa;
        }
        static int _SIZE;

        // Loop //
        static int loop1, loop2, loop3;
        static int subject_loop1;
        static int insert_subject;

        // Hold Part //
        static string HL, HL2;
        static double HL3;

        // Calculator Part //
        static double cal_p1;
        static double cal_p2;
        static double cal_p3;

        // Verify Part //
        static string _VE1_string;
        static string _VE2_string;
        static double _VE3_double;
        static int _VX_sel;
        static string password;
        static string password1;

        // Password Verifying Part // 
        static string pwd1;
        static string nameuser;
        static string _VE4_user;

        static void Main(string[] args)
        {

            Console.Write("Enter Name of User : ");
            nameuser = Console.ReadLine();

            do {
                Console.Write("New User ? (Y for Yes / N for No) : ");
                _VE4_user = Console.ReadLine();
                if (_VE4_user == "Y")
                {
                    Console.WriteLine(":- Welcome To Grade Evaluation System -:");
                    Console.Write("Enter Password : ");
                    password = Console.ReadLine();
                    password1 = password;

                    try
                    {
                        StreamWriter pwd_X = new StreamWriter("C:\\_data\\PWD_" + nameuser + ".pwd_K", true);
                        pwd_X.WriteLine(password);
                        pwd_X.Close();
                    }

                    catch (Exception e)
                    {
                        Console.WriteLine("Error : " + e.Message);
                    }
                }
                else if (_VE4_user == "N")
                {

                }
           } while (_VE4_user != "N" && _VE4_user != "Y");

            do
                {
                NWSM:
                    Console.WriteLine(":- Welcome To Grade Evaluation System -:");
                    Console.Write("Enter Password : ");
                    password = Console.ReadLine();
                    password1 = password;

                    try
                    {
                        StreamReader pwd_R = new StreamReader("C:\\_data\\PWD_" + nameuser + ".pwd_K", true);
                        pwd1 = pwd_R.ReadLine();
                        pwd_R.Close();
                    }

                    catch (Exception e)
                    {
                        Console.WriteLine("Error : " + e.Message);
                    }

                    if (pwd1 != password)
                    {
                        Console.Write("Invalid Password !");
                        Console.WriteLine("Please Enter New One!");
                    goto NWSM;
                    }

                    Console.Write("Enter People to Calculate GPAX : ");
                    int.TryParse(Console.ReadLine(), out _SIZE);

                } while (password.Length < 4);

            // Array Declarations //
            Console.WriteLine("Hello , I'm Assistant of Teacher on 90's ");
            student_record[] record_p1 = new student_record[_SIZE];

            // Record Student Before Subject Path //
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

                Console.Write("Enter Subject for Grade Calculation and Evaluation : ");
                int.TryParse(Console.ReadLine(), out insert_subject);

                Console.Write("Enter Student Name : ");
                record_p1[loop1].student_name = Console.ReadLine();
                _VE2_string = record_p1[loop1].student_name;


                if (_VE1_string.Length > 8 || _VE1_string.Length < 8 || _VE2_string.Length < 1 || _VE3_double > 4.00 || _VE3_double < 0.00)
                {
                    Console.WriteLine("Invalid Information on [{0}]", loop1);
                    Console.WriteLine("Enter New Information ! ");
                    goto X;
                }
            }
                subject_structure[] subject_p2 = new subject_structure[insert_subject];

                // Record Subject Path //
                for (loop1 = 0; loop1 < _SIZE; loop1++)
                {
                    Console.WriteLine();
                    Console.WriteLine("Subject Recording for {0}", record_p1[loop1].student_name);
                // Subject Enter Loop //
                for (subject_loop1 = 0; subject_loop1 < insert_subject; subject_loop1++)
                    {
                        Console.Write("Enter Subject To Record : ");
                        subject_p2[loop1].subject = Console.ReadLine();

                        Console.Write("Enter {0} GPAX in {1}: ", record_p1[loop1].student_name, subject_p2[loop1].subject);
                        double.TryParse(Console.ReadLine(), out subject_p2[loop1].student_GPA);
                        _VE3_double = subject_p2[loop1].student_GPA;

                        Console.Write("Enter {0} GPA Weight : ", subject_p2[loop1].subject);
                        double.TryParse(Console.ReadLine(), out subject_p2[loop1].stdsub_weight);
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

                for (loop1 = 0; loop1 < _SIZE; loop1++)
                {
                    cal_p1 += subject_p2[loop1].student_GPA * subject_p2[loop1].stdsub_weight;
                    cal_p2 += subject_p2[loop1].stdsub_weight;
                    cal_p3 = cal_p1 / cal_p2;
                    subject_p2[loop1].finishgpa = cal_p3;
                }

                for (loop2 = 1; loop2 < _SIZE - 1; loop2++)
                {
                    for (loop3 = 0; loop3 < _SIZE - 2; loop3++)
                    {
                        if (string.Compare(record_p1[loop3].student_name, record_p1[loop3 + 1].student_name, true) > 0)
                        {

                            if (_VX_sel == 1)
                            {

                                HL3 = subject_p2[loop3].finishgpa;
                                subject_p2[loop3].finishgpa = subject_p2[loop3 + 1].finishgpa;
                                subject_p2[loop3 + 1].finishgpa = HL3;

                                HL = record_p1[loop3].student_name;
                                record_p1[loop3].student_name = record_p1[loop3 + 1].student_name;
                                record_p1[loop3 + 1].student_name = HL;

                                HL2 = record_p1[loop3].student_id;
                                record_p1[loop3].student_id = record_p1[loop3 + 1].student_id;
                                record_p1[loop3 + 1].student_id = HL2;

                            }
                            else if (_VX_sel == 2)
                            {
                                HL2 = record_p1[loop3].student_id;
                                record_p1[loop3].student_id = record_p1[loop3 + 1].student_id;
                                record_p1[loop3 + 1].student_id = HL2;

                                HL = record_p1[loop3].student_name;
                                record_p1[loop3].student_name = record_p1[loop3 + 1].student_name;
                                record_p1[loop3 + 1].student_name = HL;

                                HL3 = subject_p2[loop3].finishgpa;
                                subject_p2[loop3].finishgpa = subject_p2[loop3 + 1].finishgpa;
                                subject_p2[loop3 + 1].finishgpa = HL3;

                            }
                            else if (_VX_sel == 3)
                            {

                                HL2 = record_p1[loop3].student_id;
                                record_p1[loop3].student_id = record_p1[loop3 + 1].student_id;
                                record_p1[loop3 + 1].student_id = HL2;

                                HL3 = subject_p2[loop3].finishgpa;
                                subject_p2[loop3].finishgpa = subject_p2[loop3 + 1].finishgpa;
                                subject_p2[loop3 + 1].finishgpa = HL3;

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
                    Console.WriteLine("Student {0} ID : {1}", record_p1[loop1].student_name, record_p1[loop1].student_id);
                    Console.WriteLine("GPAX of {0} is : {1:F2}", record_p1[loop1].student_name, subject_p2[loop1].finishgpa);
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
                        for (loop2 = 0; loop2 < 10; loop2++)
                        {
                            _Fx.Write("STUDENT {0} STUDENT ", loop1 + 1);
                        }
                        _Fx.WriteLine();
                        _Fx.WriteLine("Student {0,5} ID : {1,5}", record_p1[loop1].student_name, record_p1[loop1].student_id);
                        _Fx.WriteLine("GPAX of {0,5} is : {1,5:F2}", record_p1[loop1].student_name, subject_p2[loop1].finishgpa);
                        _Fx.Close();
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("Error : " + e.Message);
                }

                Console.ReadKey();
            }
        }
    }
