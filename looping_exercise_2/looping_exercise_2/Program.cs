using System;

namespace looping_exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make an array with at least 3 items
            String[] myArray = new String[3];
            myArray[0] = "Hello";
            myArray[1] = "World";
            myArray[2] = "!";
            int maxLength = 0;
            string frame = "";
            // Loop through the array

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i].Length > maxLength)
                {
                    maxLength = myArray[i].Length;
                }
            }

            for (int i = 0; i<myArray.Length; i++)
            {
                for (int k = 0; myArray[i].Length < maxLength; k++)
                {
                    myArray[i] += " ";
                }

                // Wrap the array in a frame
                myArray[i] = myArray[i].Insert(0, "*");
                myArray[i] = myArray[i].Insert(myArray[i].Length, "*");

                
                if (i == 0)
                {
                    for (int j = 0; j < maxLength + 2; j++)
                    {
                        frame += "*";
                    }
                    Console.WriteLine(frame);
                }

                Console.WriteLine(myArray[i]);
            }

            Console.WriteLine(frame);

        }
    }
}
