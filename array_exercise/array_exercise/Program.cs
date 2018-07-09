using System;

namespace array_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an array of at least 5 values
            int[] myArray = new int[5];
            // Loop through the array to assign values to each index.
            for (int i = 0; i < myArray.Length; i++) 
            {
                // Prompt user for values
                Console.WriteLine("Please enter an integer.");
                int input = Convert.ToInt32(Console.ReadLine());
                myArray[i] = input;
                Console.WriteLine("Iteration: " + i + ". Input: " + input);
            }
            // Give a space inbetween outputs.
            Console.WriteLine();

            // Reverse the array
            Array.Reverse(myArray);

            // Loop through the array again and display it.
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
        }
    }
}
