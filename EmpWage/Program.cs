using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage
{
    public class EmployeeUseCase2
    {
        public static void Main(string[] args)
        {
            int isPresent = 1;
            int empWage = 0;
            int ratePerHrs = 20;
            int empHrs = 0;

            Random employee = new Random();
            int randomInput = employee.Next(0, 2);

            if (randomInput == isPresent)
            {
                Console.WriteLine("Employee is Present");
                empHrs = 8;
            }
            else 
            {
                Console.WriteLine("Employee is Absent");
                empHrs = 0;
            }
            empWage = ratePerHrs * empHrs;
            Console.WriteLine("Employee wage per day: "+empHrs);
            Console.ReadLine();
        }
    }
}