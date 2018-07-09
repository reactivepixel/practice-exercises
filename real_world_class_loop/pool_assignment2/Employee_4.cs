using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// The following exercise will have you create two new properties for the employee class. weeklyPay, and yearlyPay.You will need to create a method to calculate 
// these values and set the properties when the constructor is called.
// 1.	Alter the constructor to accept a value for hoursWorked
// 2.	Create a method to calculate the weeklyPay and yearlyPay. (Assume that the employee will get the same amount of hours each week for the yearlyPay).
// 3.	Call this method in the constructor to set the values when the employee is calculated.
// 4.	Display all the employees.


namespace pool_assignment2
{
    class Employee_4
    {
        public Employee_4(string name, string employer, string occupation, double hourlyRate, double hoursWorked)
        {
            this.name = name;
            this.employer = employer;
            this.occupation = occupation;
            this.hourlyRate = hourlyRate;
            this.hoursWorked = hoursWorked;
            this.weeklyPay = 0.00;
            this.yearlyPay = 0.00;
            this.calculatePay();
        }
        public string name { get; set; }
        public string employer { get; set; }
        public string occupation { get; set; }
        public double hourlyRate { get; set; }
        public double hoursWorked { get; set; }
        public double weeklyPay { get; set; }
        public double yearlyPay { get; set; }


        public void display()
        {
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("Employee:");
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Employer: " + this.employer);
            Console.WriteLine("Hourly Rate: " + this.hourlyRate);
            Console.WriteLine("Hours Worked: " + this.hoursWorked);
            Console.WriteLine("Weekly Pay: " + this.weeklyPay);
            Console.WriteLine("Yearly Pay: " + this.yearlyPay);
            Console.WriteLine("**********************************************************************");
        }

        public void calculatePay()
        {
            this.weeklyPay = this.hourlyRate * this.hoursWorked;
            this.yearlyPay = weeklyPay * 52;
        }
    }
}
