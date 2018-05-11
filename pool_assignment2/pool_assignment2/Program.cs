using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pool_assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            // ***************************************************************************
            // Exercise 1
            Employee_1 myEmployee = new Employee_1("Bob");
            myEmployee.display();
            // ***************************************************************************

            // ***************************************************************************
            // Exercise 2
            Employee_2 myEmployee2 = new Employee_2("Same", "Jared", "Sales Associate", 8.50);
            myEmployee2.display();
            // ***************************************************************************

            // ***************************************************************************
            // Exercise 3
            Console.WriteLine("Please enter how many employees you would like to create.");
            int numberOfEmployees = Convert.ToInt32(Console.ReadLine());
            List<Employee_3> employees = new List<Employee_3>();
            for (int i = 0; i < numberOfEmployees; i++)
            {
                Console.WriteLine("Please enter a name for the employee.");
                string employeeName = Console.ReadLine();
                Console.WriteLine("Please enter a name for " + employeeName + "'s employer.");
                string employerName = Console.ReadLine();
                Console.WriteLine("Please enter an occupation for " + employeeName + ".");
                string occupation = Console.ReadLine();
                Console.WriteLine("How much does " + employeeName + " make per hour?");
                double hourlyRate = Convert.ToDouble(Console.ReadLine());
                Employee_3 newEmployee = new Employee_3(employeeName, employerName, occupation, hourlyRate);
                employees.Add(newEmployee);
            }
            for (int i = 0; i < employees.Count; i++)
            {
                employees[i].display();
            }
            // ***************************************************************************

            // ***************************************************************************
            // Exercise 4
            Console.WriteLine("Please enter how many employees you would like to create.");
            int numOfEmployees = Convert.ToInt32(Console.ReadLine());
            List<Employee_4> employeeList = new List<Employee_4>();
            for (int i = 0; i < numOfEmployees; i++)
            {
                Console.WriteLine("Please enter a name for the employee.");
                string employeeName = Console.ReadLine();
                Console.WriteLine("Please enter a name for " + employeeName + "'s employer.");
                string employerName = Console.ReadLine();
                Console.WriteLine("Please enter an occupation for " + employeeName + ".");
                string occupation = Console.ReadLine();
                Console.WriteLine("How much does " + employeeName + " make per hour?");
                double hourlyRate = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("How many hours did " + employeeName + " work this week?");
                double hoursWorked = Convert.ToDouble(Console.ReadLine());
                Employee_4 theNewEmployee = new Employee_4(employeeName, employerName, occupation, hourlyRate, hoursWorked);
                employeeList.Add(theNewEmployee);
            }

            for (int i = 0; i < employeeList.Count; i++)
            {
                employeeList[i].display();
            }

            // ***************************************************************************

        }
    }
}
