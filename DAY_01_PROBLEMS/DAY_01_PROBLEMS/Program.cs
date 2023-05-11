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
            Console.WriteLine("1.ListOfFriendsName\n2.Math1\n3.Perimetre_Area_Circle\n4.String_Num\n5.DateTime_ExecutionTime\n6.Avg_Random_Num");
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
                case 2:
                    Math1 math1 = new Math1();
                    math1.Numbers();
                    break;
                case 3:
                    Perimetre_Area_Circle pac = new Perimetre_Area_Circle();
                    pac.Circle();
                    break;
                case 4:
                    String_Num sn = new String_Num();
                    sn.StNu();
                    break;
                case 5:
                    DateTime_ExecutionTime dt= new DateTime_ExecutionTime();
                    dt.Date_Execution_Time();
                    break;
                case 6:
                    Avg_Random_Num arn=new Avg_Random_Num();
                    arn.Random_Avg();
                    break;

            }
        }
    }
}



