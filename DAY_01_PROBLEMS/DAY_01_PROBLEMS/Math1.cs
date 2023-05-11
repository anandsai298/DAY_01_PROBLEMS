using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_01_PROBLEMS
{
    public class Math1
    {
        public void Numbers()
        {
            Console.WriteLine("Enter first number N1:");
            double N1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter first number N2:");
            double N2=Convert.ToDouble(Console.ReadLine());
            double sum = N1 + N2;
            double diff = N1 - N2;
            double sq_Sum = Math.Pow(sum,2);
            double sq_Diff=Math.Pow(diff,2);
            Console.WriteLine("Square of sum of N1 & N2 :"+ sq_Sum +"\n"+"Square of difference of N1 & N2:"+ sq_Diff);
        }
    }
}
