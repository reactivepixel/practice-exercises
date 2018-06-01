---
title: RPG - Classes and Loops
difficulty: 2
degree: WDD
outcome: Central
categories:
  - C#
  - Classes
  - Objects
  - Loops
---

`Challenge 1`
```
This assignment will contain multiple smaller assignments to create a full project.
For this exercise the character class will have the following as properties, name, health, mana, strength, dexterity, and intelligence.The constructor should ask for name.
1.	Create the character class.
2.	Make an instance of the class.
3.	Display the character(instance of the class).
```

`Challenge 2`
```
The next exercise would to create a loop prompting the user for how many characters they would like create.This would form a “party” of characters.Each character must have a unique name.
1.	Move logic around to fit in a loop
2.	Prompt user for a number of characters.
3.	Prompt the user for a new name for each character.
4.	Display all the characters. 
```

`Challenge 3`
```
The next exercise would be to add roles to the character class. This could be done in a multitude of ways.
Please use which way makes sense to you and provide (in comments) why you choose that way.The roles are Warrior, Rogue, Wizard. 
Now that each character has a role it doesn’t make sense for all wizards to have equal strength to all warriors, 
nore does it make sense for all warriors to have equal dexterity to all rogues.So the properties in the first portion of this assignment must be altered.


All characters must start with 100 health, 0 mana, 10 strength, 10 dexterity, and 10 intelligence.These values are going to be altered when on instantiation of the class. 
The constructor must require a new argument to determine the role of the character.This also can be done a number of ways, please choose one and comment why you choose that way.


If a warrior is chosen, the character gets +20 health (120 total), +4 strength(14 total), -2 dexterity(8 total), -2 intelligence(8 total). 

If a rogue is chosen, the character gets, -10 health(90 total), -3 strength(7 total), +4 dexterity(14 total), -1 intelligence(9 total).

If a wizard is chosen, the character gets, -20 health(80 total), +50 mana, -2 strength(8 total), -2 dexterity(8 total), +4 intelligence(14 total)

1.	Alter the constructor to accept a role.
2.	Add a property for the role.
3.	Alter the properties of the class based upon the chosen role.
4.	Display all the characters and their stats.
```
