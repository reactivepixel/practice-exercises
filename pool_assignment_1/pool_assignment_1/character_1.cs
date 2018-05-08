using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// This assignment will contain multiple smaller assignments to create a full project.
// For this exercise the character class will have the following as properties, name, health, mana, strength, dexterity, and intelligence.The constructor should ask for name.
// 1.	Create the character class.
// 2.	Make an instance of the class.
// 3.	Display the character(instance of the class).


namespace pool_assignment_1
{
    class Character_1
    {
        public Character_1()
        {

        }

        public Character_1(string name)
        {
            this.name = name;
            this.health = 100;
            this.mana = 0;
            this.strength = 10;
            this.dexterity = 10;
            this.intelligence = 10;

            Console.WriteLine("New character created: " + this.name);
            Console.WriteLine("Health: " + this.health);
            Console.WriteLine("Mana: " + this.mana);
            Console.WriteLine("Strength: " + this.strength);
            Console.WriteLine("Dexterity: " + this.dexterity);
            Console.WriteLine("Intelligence: " + this.intelligence);
        }
        public string name { get; set; }
        public int health { get; set; }
        public int mana { get; set; }
        public int strength { get; set; }
        public int dexterity { get; set; }
        public int intelligence { get; set; }
    }
}
