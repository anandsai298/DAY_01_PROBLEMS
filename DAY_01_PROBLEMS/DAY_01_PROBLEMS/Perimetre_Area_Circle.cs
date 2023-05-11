using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_01_PROBLEMS
{
    public class Perimetre_Area_Circle
    {
        public void  Circle()
        {
            Console.WriteLine("Enter Daiametre of a Circle:");
            double Dia=Convert.ToDouble(Console.ReadLine());
            double rad=Dia/2;
            double Perimeter=2*Math.PI*rad;
            double area = Math.PI * Math.Pow(rad, 2);
            Console.WriteLine("Perimetre of an Circle :" + Perimeter);
            Console.WriteLine("Area of an Circle:" + area);
        }
    }
}
