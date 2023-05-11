using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_01_PROBLEMS
{
    public class String_Num
    {
        public void StNu()
        {
            Console.WriteLine("Enter number:");
            string num_s=Convert.ToString(Console.ReadLine());
            int num=int.Parse(num_s);
            int res = num * 10;
            string res_s= res.ToString();
            Console.WriteLine("10 times of" + num_s + " is :" + res_s);
        }
    }
}
