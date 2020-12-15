using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Project
{
    static class Department
    {
        public static List<string> CSDeptStudents = new List<string>();
        public static List<string> ECEDeptStudents = new List<string>();
        public static List<string> MechDeptStudents = new List<string>();
        public static List<string> EEDeptStudents = new List<string>();
        public static int cs = 0;
        public static int ece = 0;
        public static int mech = 0;
        public static int ee = 0;
        public static string student_ID;
        public static void addtodept(string name, string dept_name)
        {

            switch (dept_name)
            {
                case "CS":
                    CSDeptStudents.Add(name);
                    cs++;
                    student_ID = "4NI16" + dept_name + Convert.ToString(cs);
                    break;

                case "ECE":
                    ECEDeptStudents.Add(name);
                    ece++;
                    student_ID = "4NI16" + dept_name + Convert.ToString(ece);
                    break;

                case "ME":
                    MechDeptStudents.Add(name);
                    mech++;
                    student_ID = "4NI16" + dept_name + Convert.ToString(mech);
                    break;

                case "EE":
                    EEDeptStudents.Add(name);
                    student_ID = "4NI16" + dept_name + Convert.ToString(ee);
                    ee++;
                    break;

                default:
                    Console.WriteLine("Invalid entry");
                    break;
            }

        }
        public static void department_check()
        {
            if (cs >= 100)
            {
                Console.WriteLine("CS department is full, please choose another department");

            }
            if (ece >= 60)
            {
                Console.WriteLine("ECE department is full, please choose another department");
            }
            if (mech >= 60)
            {
                Console.WriteLine("ME department is full, please choose another department");
            }
            if (ee >= 90)
            {
                Console.WriteLine("EE department is full, please choose another department");
            }

        }
    }
}
  

