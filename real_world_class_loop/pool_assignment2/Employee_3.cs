using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// The next exercise would be to create a loop prompting the user for how many employees they would like create.
// 1.	Move logic around to fit in a loop
// 2.	Prompt user for a number of employees.
// 3.	Prompt the user for an employee name, employer name, occupation, and hourly rate.
// 4.	Display all the employees. 


namespace pool_assignment2
{
    class Employee_3
    {
        public Employee_3(string name, string employer, string occupation, double hourlyRate)
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
