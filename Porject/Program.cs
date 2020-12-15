using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Validation validation = Validation.Instance;
            validation.Validate();

            Studentdbase studentdbase = new Studentdbase();
            while (true)
            {
                Console.WriteLine("Enter A to enter student details , B to see all the details or C");
                char key = Convert.ToChar(Console.ReadLine());

                switch (key)
                {
                    case 'A':
                        studentdbase.addtodbase();
                        break;
                    case 'B':
                        studentdbase.Display();
                        break;
                    case 'C':
                        studentdbase.Display_deptwise();
                        break;
                    default :
                        Console.WriteLine("Terminated");
                        break;
                }

                
                

            }

        }
    }


    }
    

