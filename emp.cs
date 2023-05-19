namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the employee wage program");
            Random rd = new Random();
            int attendance=rd.Next(0,2);
            int salary = 0;
            const int FullDayHour = 8;
            const int WagePerHour = 20;


            if (attendance == 0 )
            {
                Console.WriteLine("Employee is present");
                salary = FullDayHour * WagePerHour;
                Console.WriteLine("The salary of the emloyee is :  " + salary);
            }
            else 
            {
                Console.WriteLine("Employee is absent");
                Console.WriteLine("salary of the employee is :  " + salary );
            }

        }
    }
}