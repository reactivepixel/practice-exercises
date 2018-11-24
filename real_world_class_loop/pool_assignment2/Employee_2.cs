using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// The second exercise for this project is to define three occupations, and their
// hourlyRates.This could be anything from cashier, stocker, or office assistant.It can be
// anything you want really.The same applies for the hourly rates and employers.Modify the constructor to accept a name, employer, and occupation.
// 1.	Modify the constructor to accept a name, employer, and occupation.
// 2.	Based on the input occupation please set the hourlyRate.
// 3.	Create an instance of the class.
// 4.	Display the employee.


namespace pool_assignment2
{
    class Employee_2
    {
        public Employee_2(string name, string employer, string occupation, double hourlyRate)
        {
            this.name = name;
            this.employer = employer;
            this.occupation = occupation;
            this.hourlyRate = hourlyRate;
            this.hoursWorked = 0.00;
        }
        public string name { get; set; }
        public string employer { get; set; }
        public string occupation { get; set; }
        public double hourlyRate { get; set; }
        public double hoursWorked { get; set; }

        public void display()
        {
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("Employee:");
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Employer: " + this.employer);
            Console.WriteLine("Hourly Rate: " + this.hourlyRate);
            Console.WriteLine("Hours Worked: " + this.hoursWorked);
            Console.WriteLine("**********************************************************************");
        }
    }
}
