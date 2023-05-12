using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_01_PROBLEMS
{
    public class PlaceName
    {
        public  void Place()
        {
            Console.Write("Enter a place you would like to visit most: ");
            string place = Console.ReadLine();
            string Upper = place.ToUpper();
            string Lower = place.ToLower();

            Console.WriteLine("Uppercase of place name " + Upper );
            Console.WriteLine("lowercase of place name " + Lower );
        }
    }
}
