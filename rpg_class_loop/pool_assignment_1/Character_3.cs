using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//cThe next exercise would be to add roles to the character class. This could be done in a multitude of ways.
//cPlease use which way makes sense to you and provide (in comments) why you choose that way.The roles are Warrior, Rogue, Wizard. 
// Now that each character has a role it doesn’t make sense for all wizards to have equal strength to all warriors, 
// nore does it make sense for all warriors to have equal dexterity to all rogues.So the properties in the first portion of this assignment must be altered.


//All characters must start with 100 health, 0 mana, 10 strength, 10 dexterity, and 10 intelligence.These values are going to be altered when on instantiation of the class. 
// The constructor must require a new argument to determine the role of the character.This also can be done a number of ways, please choose one and comment why you choose that way.


// If a warrior is chosen, the character gets +20 health (120 total), +4 strength(14 total), -2 dexterity(8 total), -2 intelligence(8 total). 

// If a rogue is chosen, the character gets, -10 health(90 total), -3 strength(7 total), +4 dexterity(14 total), -1 intelligence(9 total).

// If a wizard is chosen, the character gets, -20 health(80 total), +50 mana, -2 strength(8 total), -2 dexterity(8 total), +4 intelligence(14 total)

// 1.	Alter the constructor to accept a role.
// 2.	Add a property for the role.
// 3.	Alter the properties of the class based upon the chosen role.
// 4.	Display all the characters and their stats.

namespace pool_assignment_1
{
    class Character_3
    {

        public Character_3()
        {

        }

        public Character_3(string name, int role)
        {
            this.name = name;
            this.health = 100;
            this.mana = 0;
            this.strength = 10;
            this.dexterity = 10;
            this.intelligence = 10;
            this.chosenRole = "";
            this.chooseClass(role);
        }

        public string name { get; set; }
        public int health { get; set; }
        public int mana { get; set; }
        public int strength { get; set; }
        public int dexterity { get; set; }
        public int intelligence { get; set; }
        public int role { get; set; }
        public string chosenRole { get; set; }

        public void chooseClass(int role)
        {
            if (role == 1)
            {
                // If a warrior is chosen, the character gets +20 health (120 total), +4 strength(14 total), -2 dexterity(8 total), -2 intelligence(8 total). 
                this.chosenRole = "Warrior";
                this.health += 20;
                this.strength += 4;
                this.dexterity -= 2;
                this.intelligence -= 2;
            }
            else if (role == 2)
            {
                // If a wizard is chosen, the character gets, -20 health(80 total), +50 mana, -2 strength(8 total), -2 dexterity(8 total), +4 intelligence(14 total)
                this.chosenRole = "Wizard";
                this.health -= 20;
                this.mana += 50;
                this.strength -= 2;
                this.dexterity -= 2;
                this.intelligence += 4;
            }
            else
            {
                // If a rogue is chosen, the character gets, -10 health(90 total), -3 strength(7 total), +4 dexterity(14 total), -1 intelligence(9 total).
                this.chosenRole = "Rogue";
                this.health -= 10;
                this.strength -= 3;
                this.dexterity += 4;
                this.intelligence -= 1;
            }
        }
        public void displayCharacter()
        {
            Console.WriteLine("New character created: " + this.name);
            Console.WriteLine("Class: " + this.chosenRole);
            Console.WriteLine("Health: " + this.health);
            Console.WriteLine("Mana: " + this.mana);
            Console.WriteLine("Strength: " + this.strength);
            Console.WriteLine("Dexterity: " + this.dexterity);
            Console.WriteLine("Intelligence: " + this.intelligence);
            Console.WriteLine("**********************************************************************");
        }

    }


}
