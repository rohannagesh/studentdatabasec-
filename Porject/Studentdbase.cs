using Porject;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace Project
{

    class Studentdbase
    {
        public List<Student> studentdetails = new List<Student>();
        
        public void addtodbase()

        {
            
            
            
                var student = new Student();
                
                Console.WriteLine("Enter the firstname of the student");
                student.firstname = Console.ReadLine();

                Console.WriteLine("Enter the lastname of the student");
                student.lastname = Console.ReadLine();

                Console.WriteLine("Enter the age of the student");
                student.age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the sex");
                student.sex = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("Enter the category of the student");
                student.category = Console.ReadLine();

                Console.WriteLine("Enter the CET rank of the student");
                student.cet_rank = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the Department preferred");
                student.dept_preferred = Console.ReadLine();

                Department.department_check();
                Department.addtodept(student.Fullname, student.dept_preferred);

                var fees = new Fees();
                student.fees = fees.calculatefees(student.cet_rank, student.category);
                var generated_ID = new Generate_ID(student.dept_preferred);
                student.stud_number = generated_ID.Generated_Id();
                studentdetails.Add(student);

            

        }
        public void Display()
        {
            foreach (var stud in studentdetails)
            {
                Console.WriteLine(stud.Fullname);
                Console.WriteLine(stud.stud_number);
                Console.WriteLine($"The fees to be paid is {stud.fees} ");


            }
        }
        public void Display_deptwise()
        {
            Console.WriteLine("The students in CS department are:");
            foreach (var stud in Department.CSDeptStudents)
            {
                Console.WriteLine(stud);
            }
            Console.WriteLine("The students in ECE department are:");
            foreach (var stud in Department.ECEDeptStudents)
            {
                Console.WriteLine(stud);
            }
            Console.WriteLine("The students in ME department are:");
            foreach (var stud in Department.MechDeptStudents)
            {
                Console.WriteLine(stud);
            }
            Console.WriteLine("The students in EE department are:");
            foreach (var stud in Department.EEDeptStudents)
            {
                Console.WriteLine(stud);
            }
        }
            



        }
    }





 