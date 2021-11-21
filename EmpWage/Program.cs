using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage.UseCase3
{
    public class EmployeeUseCase3
    {
        public static void Main(string[] args)
        {
            int is_Full_Time = 1;
            int is_Half_Time = 2;
            int empWage = 0;
            int ratePerHrs = 20;
            int empHrs = 0;

            Random employee = new Random();
            int randomInput = employee.Next(0, 3);

            if (randomInput == is_Full_Time)
            {
                Console.WriteLine("Full Time Employee is Present");
                empHrs = 8;
            }
            else if(randomInput == is_Half_Time)
            {
                Console.WriteLine("Part Time Employee is Present");
                empHrs = 8 / 2;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            empWage = ratePerHrs * empHrs;
            Console.WriteLine("Employee wage per day: " + empHrs);
            Console.ReadLine();
        }
    }
}
