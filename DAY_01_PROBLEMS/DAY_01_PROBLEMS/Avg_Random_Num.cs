using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_01_PROBLEMS
{
    public class Avg_Random_Num
    {
        public void Random_Avg()
        {
           
            int[] Rand=new int[5];
            for(int i=0; i<5; i++)
            {
                Random random = new Random();
                Rand[i] = random.Next(10, 51);
            }
            
            double sum = 0;
            foreach(int j in Rand)
            {
                sum += j;
            }
            double avg = sum / 5;
            Console.WriteLine("random numbers (10-51) :"+string.Join(",",Rand)+"\n"+"Average of random numbers:"+avg);
        }
    }
}
