using System;

namespace random_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a random number 1-10
            Random rnd = new Random();
            int answer = rnd.Next(1, 10 + 1);
            bool isCorrect = false;

            // Loop until user guesses the correct answer
            do
            {
                Console.WriteLine("Please guess a number between 1 and 10");
                int userAnswer = Convert.ToInt32(Console.ReadLine());
                if (userAnswer == answer)
                {
                    isCorrect = true;
                    Console.WriteLine("Congrats!");
                }
            } while (isCorrect == false);
        }
    }
}
