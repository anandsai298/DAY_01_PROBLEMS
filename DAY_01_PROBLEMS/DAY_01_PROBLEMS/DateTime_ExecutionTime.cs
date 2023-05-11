using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_01_PROBLEMS
{
    public class DateTime_ExecutionTime
    {
        public void Date_Execution_Time()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int year = 2020;
            int Month = 08;
            int Day = 23;
            DateTime date=new DateTime(year, Month, Day);
            date=date.AddDays(1);
            string date_s=date.ToString();
            Console.WriteLine("Next of given Date(dd/mm/yyyy) -->" + date_s);
            stopwatch.Stop();
            Console.WriteLine("Execution Time -->"+stopwatch.ElapsedMilliseconds+"ms");
        }
    }
}
