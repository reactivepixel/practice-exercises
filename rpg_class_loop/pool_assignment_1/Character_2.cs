using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// The next exercise would to create a loop prompting the user for how many characters they would like create.This would form a “party” of characters.Each character must have a unique name.
// 1.	Move logic around to fit in a loop
// 2.	Prompt user for a number of characters.
// 3.	Prompt the user for a new name for each character.
// 4.	Display all the characters. 


namespace pool_assignment_1
{
    class Character_2
    {

        public Character_2()
        {

        }

        public Character_2(string name)
        {
            this.name = name;
            this.health = 100;
            this.mana = 0;
            this.strength = 10;
            this.dexterity = 10;
            this.intelligence = 10;
        }
        public string name { get; set; }
        public int health { get; set; }
        public int mana { get; set; }
        public int strength { get; set; }
        public int dexterity { get; set; }
        public int intelligence { get; set; }

        public void displayCharacter()
        {
            Console.WriteLine("New character created: " + this.name);
            Console.WriteLine("Health: " + this.health);
            Console.WriteLine("Mana: " + this.mana);
            Console.WriteLine("Strength: " + this.strength);
            Console.WriteLine("Dexterity: " + this.dexterity);
            Console.WriteLine("Intelligence: " + this.intelligence);
            Console.WriteLine("**********************************************************************");

        }
    }
}
