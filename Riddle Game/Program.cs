using System;

namespace ChooseYourOwnAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Hello, {name}! Welcome to our story.");
            Console.WriteLine("It begins on a dark and stormy night. You hear a ghostly cry from down the hall from your bedroom. Do you go investigate?");

            Console.WriteLine("Type YES or NO:");
            string noiseChoice = Console.ReadLine().ToUpper();

            if (noiseChoice == "NO")
            {
                Console.WriteLine("Guess we will never know what that was! THE END.");
            }
            else if (noiseChoice == "YES")
            {
                Console.WriteLine("You walk into the hallway and see the shadow of what looks like a human figure glide through one of the doors. You walk up to the door. Do you open it or knock?");
                Console.WriteLine("Type OPEN or KNOCK:");
                string doorChoice = Console.ReadLine().ToUpper();

                if (doorChoice == "KNOCK")
                {
                    Console.WriteLine("A voice behind the door speaks. It says, 'Answer this riddle: ");
                    Console.WriteLine("I speak without a mouth and hear without ears. I have no body, but I come alive with the wind. What am I? ");
                    Console.WriteLine("Type your answer:");
                    string firstChoice = Console.ReadLine();
                    string riddleChoice = firstChoice.ToUpper();

                    if (riddleChoice == "ECHO")
                    {
                        Console.WriteLine("The door opens and a music box is there. You turn off the light, run back to your room and lock the door. THE END.");
                    }
                    else
                    {
                        Console.WriteLine("You answered incorrectly. The door doesn't open. THE END.");
                    }
                }
                else if (doorChoice == "OPEN")
                {
                    Console.WriteLine("The door is locked! See if one of your three keys will open it.");
                    Console.WriteLine("Enter a number (1-3):");
                    string keyChoice = Console.ReadLine().ToUpper();

                    switch (keyChoice)
                    {
                        case "1":
                            Console.WriteLine("You chose the first key. Lucky choice! The door opens. There is a music box on the floor. Strange...THE END.");
                            break;
                        case "2":
                            Console.WriteLine("You chose the second key. The door doesn't open. THE END.");
                            break;
                        case "3":
                            Console.WriteLine("You chose the third key. The door doesn't open. THE END.");
                            break;
                    }
                }
            }
        }

    }
}