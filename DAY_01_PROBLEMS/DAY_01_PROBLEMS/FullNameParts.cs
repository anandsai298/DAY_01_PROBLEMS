using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_01_PROBLEMS
{
    public class FullNameParts
    {
        public void Name()
        {
            int count = 2;
            Console.WriteLine("Enter First Name:");
            string Fn=Console.ReadLine();
            Console.WriteLine("Enter Last Name:");
            string Ln = Console.ReadLine();
            Console.WriteLine("Enter Middle Name:");
            string Mn = Console.ReadLine();
            if(string.IsNullOrEmpty(Mn))
            {
                Console.WriteLine("The middle name is missing");
            }
            else
            {
                string[] words=Mn.Split(" ");
                count += words.Length;
            }
            Console.WriteLine("No of Parts in Name" + count);
            string FullName = (Fn + " " + Mn + " " + Ln);
            Console.WriteLine(FullName);
        }
    }
}
