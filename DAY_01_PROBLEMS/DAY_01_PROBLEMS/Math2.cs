using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_01_PROBLEMS
{
    public class Math2
    {
        public void Modulus()
        {
            int[] num = new int[1200];

            for (int i=2000; i<=3200;i++)
            {
                if(i%7==0 && i%5!=0)
                {
                    Console.WriteLine(i.ToString()+",");
                }
            }
        }
    }
}
