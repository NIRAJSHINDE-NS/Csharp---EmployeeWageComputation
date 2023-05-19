namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the employee wage program");
            Random rd = new Random();
            int attendance=rd.Next(0,3);
            int salary = 0;
            const int WagePerHour = 20;
            const int present = 0;
            const int absent = 1;
            int dailyHour = 0;


            if (attendance == present )
            {
                Console.WriteLine("Employee is present");
                dailyHour = 8;
                
            }

            else if (attendance == absent ) 
            {
                Console.WriteLine("Employee is absent");
                dailyHour = 0;
            }
            else
            {
                Console.WriteLine("Employee is present part time ");
                dailyHour = 4;
            }
            
            salary = dailyHour * WagePerHour;
            Console.WriteLine("The salary of the emloyee is :  " + salary );

        }
    }
}   