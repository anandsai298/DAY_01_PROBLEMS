// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.InteropServices;

namespace DAY_01_PROBLEMS;
class problem 
{
    static void Main(string[] args)
    {
        bool flag = true;
        while(flag)
        {
            Console.WriteLine("Select option to display");
            Console.WriteLine("1.ListOfFriendsName\n2.Math1\n3.Perimetre_Area_Circle");
            int option=Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    string[] Friends = { "Anand", "Sai", "Kumar", "Vijaya", "Rowthu" };
                    Console.WriteLine("List of Friends Names are:");
                    foreach(string friend in Friends)
                    {
                        Console.WriteLine(friend);
                    }
                    break;
              
            }
        }
    }
}



