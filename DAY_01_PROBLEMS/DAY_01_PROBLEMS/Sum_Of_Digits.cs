using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_01_PROBLEMS
{
    public class Sum_Of_Digits
    {
        public static int Sum(int num)
        {    
            if (num < 10)
            {
                return  num;
               
            }
            else
            {
                int LD = num % 10;
                int RD= num / 10;
                int res = LD + Sum(RD);
                return res;
                
            }

        }
    }
}
