namespace Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO EMPLOYEE WAGE COMPUTATION PROGRAM");
            Console.WriteLine("--------------------------------------------");

            Random random = new Random();

            int salary = 0, daily_hour = 0, total_working_hour = 0, monthly_salary = 0 ;
            int salary = 0, daily_hour = 0, total_working_hour = 0, monthly_salary = 0 , day =1;

            //Constant variables
            const byte IS_PRESENT_FULL_TIME = 1;
            const byte IS_PRESENT_PART_TIME = 2;
            const byte WAGE_PER_HOUR = 20;
            const byte TOTAL_WORKING_DAYS = 20;
            const byte MAX_WORKING_HOURS = 100;

        

            for(int day=1; day<=TOTAL_WORKING_DAYS; day++)
            
            while(day <= TOTAL_WORKING_DAYS && total_working_hour <= MAX_WORKING_HOURS)
            {
                int attendance = random.Next(0, 3);
                switch (attendance)            
                Console.WriteLine("Total working hours : " + total_working_hour);
                Console.WriteLine("--------------------------------------------");
                day++;
            }

           
            monthly_salary = total_working_hour * WAGE_PER_HOUR;
            Console.WriteLine("Monthly salary of Employee is Rs." + monthly_salary);
        }
    }
}