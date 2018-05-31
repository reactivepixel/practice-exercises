using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pool_assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // ***************************************************************************
            // Exercise 1
            Console.WriteLine("Hello World");
            Character_1 character = new Character_1("Gaulthor");
            Console.WriteLine("**********************************************************************");


            // ***************************************************************************

            // ***************************************************************************
            // Exercise 2
            Console.WriteLine("Please enter a number. You will be prompted for that many names.");
            string userNumber = Console.ReadLine();
            Console.WriteLine("**********************************************************************");
            List<Character_2> partyTwo = new List<Character_2>();
            int numberofCharacters = Convert.ToInt32(userNumber);
            for (int i = 0; i < numberofCharacters; i++)
            {
                Console.WriteLine("Please enter a name for your character.");
                string userInput = Console.ReadLine();
                Console.WriteLine("**********************************************************************");
                Character_2 characterLoop = new Character_2(userInput);
                partyTwo.Add(characterLoop);
            }
            for (int i = 0; i < partyTwo.Count; i++)
            {
                partyTwo[i].displayCharacter();
            }
            // ***************************************************************************

            // ***************************************************************************
            // Exercise 3
            Console.WriteLine("Please enter a number. You will be prompted for that many names and roles.");
            string userInputNumber = Console.ReadLine();
            int numberofIterations = Convert.ToInt32(userInputNumber);
            Console.WriteLine("**********************************************************************");
            List<Character_3> party = new List<Character_3>();
            
            for (int i = 0; i < numberofIterations; i++)
            {
                Console.WriteLine("Please enter a name.");
                string charName = Console.ReadLine();
                Console.WriteLine("Please enter 1, 2, or 3. (1: Warrior, 2: Wizard, 3: Rogue)");
                string charClass = Console.ReadLine();
                Console.WriteLine("**********************************************************************");
                int charNum = Convert.ToInt32(charClass);
                Character_3 characterIteration = new Character_3(charName, charNum);
                party.Add(characterIteration);
            }

            for (int i = 0; i < party.Count; i++)
            {
                party[i].displayCharacter();
            }

            // ***************************************************************************


        }
    }
}
