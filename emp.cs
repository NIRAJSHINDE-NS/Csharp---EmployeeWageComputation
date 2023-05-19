using Microsoft.VisualBasic;
using System.Drawing;
using System.Globalization;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the employee wage program");

           
            int salary = 0;
            const int WagePerHour = 20;
            const int present = 0;
            const int absent = 1;
            const int month = 20;
            int dailyHour = 0;
            const int TotalWorkingDays = 20;
            const int MaxWorkingHours = 100;

            for (int i = 0; i <= TotalWorkingDays; i++)
            {
                for (int j = 0; j <= MaxWorkingHours; j++) ;
                {
                    Random rd = new Random();
                    int attendance = rd.Next(0, 3);

                    switch (attendance)
                    {
                        case present:
                            Console.WriteLine("The employee is present full time  ");
                            dailyHour = 8;
                            break;
                        case absent:
                            Console.WriteLine("The employee is absent ");
                            dailyHour = 0;
                            break;
                        default:
                            Console.WriteLine("The employee is present part time ");
                            dailyHour = 4;
                            break;
                    }

                    salary = dailyHour * WagePerHour;
                    Console.WriteLine("The salary of the emloyee is :  " + salary + " /- rs");

                    Console.WriteLine("The monthly salary of the employee is :  " + month * salary + " /- rs");
                }
            }
        }       
    }
}
