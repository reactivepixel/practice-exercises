using System;
using System.Linq;

namespace looping_exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user for an int
            Console.WriteLine("Please enter an integer.");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] myArray = new int[num];
            // Loop a number of times equal to num
            for (int i = 0; i < num; i++)
            {
                // Prompt a user for an integer and push it to the array.
                Console.WriteLine("Please enter another integer.");
                int loopNum = Convert.ToInt32(Console.ReadLine());
                myArray[i] = loopNum;
                Console.WriteLine("Iteration: " + i + ". Number: " + loopNum);
            }

            // Find the highest value in the array.
            Console.WriteLine("The highest value is: " + myArray.Max());
        }
    }
}
