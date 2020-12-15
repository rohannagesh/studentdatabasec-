using System;
using System.Collections.Generic;
using System.Text;

namespace Porject
{
    class Fees
    {
        private int fees;
        public int calculatefees(Nullable<int> rank, string cat)
        {
            if (rank > 0 && rank < 20000)
            {  
                if (cat == "Gen")
                {
                    fees = 45000;
                }
                else if (cat == "OBC")
                {
                    fees = 20000;
                }
            }
            else if (rank != null && rank > 20000)
            {
                fees = 150000;
            }
            else if (rank == 0)
            {
                fees = 1000000 + 50000;
            }
            return fees;
        } 
    }
}
