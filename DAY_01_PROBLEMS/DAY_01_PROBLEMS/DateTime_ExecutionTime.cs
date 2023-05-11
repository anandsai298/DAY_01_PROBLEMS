using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_01_PROBLEMS
{
    public class DateTime_ExecutionTime
    {
        public void Date_Execution_Time()
        {
            Console.WriteLine("Enter the Year :");
            int year=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Month B/W (1-12) :");
            int Month= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Day B/W (1-30 or 31):");
            int Day= Convert.ToInt32(Console.ReadLine());
            DateTime date=new DateTime(year, Month, Day);
            date=date.AddDays(1);
            string date_s=date.ToString();
            Console.WriteLine("Next of given Date(dd/mm/yyyy) -->" + date_s);
        }
    }
}
