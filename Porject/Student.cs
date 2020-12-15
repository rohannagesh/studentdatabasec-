using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class Student
    {
        
        public int age;
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string category { get; set; }
        public string dept_preferred;
        public int cet_rank;
        public char sex;
        public int fees;
        public string stud_number;
        public string Fullname
        {
            get
            {
                return firstname + " " + lastname;
            }
            
        }
                                         

    }
}
