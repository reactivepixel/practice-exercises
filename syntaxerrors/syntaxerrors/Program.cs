using System;

namespace syntaxerrors
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Please enter how many times you would like to loop.");
            // int numOfLoops = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("********************************************");
            // for (int x = 0; x < numOfLoops; x++)
            // {
            //    Console.WriteLine("Loop Iterations: " + (x+1));
            //}

            // In this exercise you are to find and fix all of the syntax errors.
            // 1. Find all syntax errors and correct them.
            // 2. Display the number of iterations of the loop (1 through your input number).
            

             Console.WriteLine("Please enter how many times you would like to loop.");
             int numOfLoops = Console.ReadLine();

             for (x = 0; x < numOfLoops; x++)
             {
                 Console.WriteLine("Loop Iterations: " + x+1);
             }
        }
    }
}
