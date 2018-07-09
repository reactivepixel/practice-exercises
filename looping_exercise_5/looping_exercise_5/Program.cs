using System;
using System.Linq;
namespace looping_exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt user for an integer.
            Console.WriteLine("Please enter an integer.");
            int input = Convert.ToInt32(Console.ReadLine());
            // Create an array
            int[] myArray = new int[input];
            for (int i = 0; i < input; i++)
            {
                // Prompt user for another integer
                Console.WriteLine("Please enter another integer.");
                int num = Convert.ToInt32(Console.ReadLine());
                myArray[i] = num;
            }
            Console.WriteLine();
            Console.WriteLine("The sum of the array is, " + myArray.Sum());
        }
    }
}
