using System;

namespace looping_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Promt the user for a number (integer).
            Console.WriteLine("Please enter a whole number.");
            // Capture the result.
            int num = Convert.ToInt32(Console.ReadLine());

            // Loop a number of times equal to the captured number.
            for (int i = 0; i<num; i++)
            {
                // Print out each current iteration.
                Console.WriteLine("Iteration: " + (i +1));
            }

        }
    }
}
