using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// For this exercise the employee class will have the following as properties, name, employer, occupation, hourlyRate, hoursWorked. The constructor should ask for name.
// 1.	Create the employee class.
// 2.	Make an instance of the class.
// 3.	Display the employee(instance of the class).

namespace pool_assignment2
{
    class Employee_1
    {
        public Employee_1(string name)
        {
            this.name = name;
            this.employer = "";
            this.occupation = "";
            this.hourlyRate = 0.00;
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
