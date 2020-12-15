using Project;
using System;
using System.Collections.Generic;
using System.Text;

namespace Porject
{
    class Generate_ID
    {
        public string student_ID;
        public Generate_ID() { }
        public Generate_ID(string dept)
        {
            if (dept == "CS")
            {
                student_ID = "4NI16" + dept + Convert.ToString(Department.cs);
            }

            else if (dept == "ECE")
            {
                student_ID = "4NI16" + dept + Convert.ToString(Department.ece);
            }
            else if (dept == "ME")
            {
                student_ID = "4NI16" + dept + Convert.ToString(Department.mech);
            }
            else
            {
                student_ID = "4NI16" + dept + Convert.ToString(Department.ee);
            }
           
        }
        public string Generated_Id()
        {
            return student_ID;
        }

    }
}
