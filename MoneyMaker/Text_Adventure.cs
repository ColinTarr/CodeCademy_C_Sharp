using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseYourOwnAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            /* THE MYSTERIOUS NOISE */

            // Start by asking for the user's name:
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! Welcome to our story.");

            Console.WriteLine("It begins on a cold rainy night. You're sitting at your campsite and hear a noise coming from the woods. Do you go investigate?");

            Console.Write("Type YES or NO: ");
            string Choice1 = Console.ReadLine();
            Choice1 = Choice1.ToUpper();

            if (Choice1 == "NO")
            {
                Console.WriteLine("You go to bed and nothing happens, what a bore.");
                Console.WriteLine("THE END");
            }
            else if (Choice1 == "YES")
            {
                Console.WriteLine("You walk into the woods and see a dark figure in the distance.");
                Console.WriteLine("You walk towards it slowly, and stop behind a tree. Do you call out to it or wait and watch.");

                Console.Write("Type CALL or WAIT: ");
                string Choice2 = Console.ReadLine();
                Choice2 = Choice2.ToUpper();
                Choice2.ToUpper();

                if (Choice2 == "CALL")
                {
                    Console.WriteLine("You call to the figure. You see it turn around slowly and can feel its glare. It charges you immediately...");
                    Console.WriteLine("You run as fast as you can to your campsite, and remember you have a gun in one of your tents but cant remember which one. Is it in the Red, Blue, or Green Tent?");
                    Console.Write("Type RED, BLUE, or GREEN: ");
                    string Choice3 = Console.ReadLine();

                    switch (Choice3)
                    {
                        case "RED":
                            Console.WriteLine("You run to the tent and find that this contained your food supply. Too bad you'll also be food in a second...");
                            Console.WriteLine("THE END.");
                            break;

                        case "BLUE":
                            Console.WriteLine("You run to the tent and find that this contained your clothes and bed. Unlucky choice...");
                            Console.WriteLine("THE END");
                            break;

                        case "GREEN":
                            Console.WriteLine("You run to the tent and find that this contained your gun. You turn around and prep yourself to pull the trigger...");
                            Console.WriteLine("The monster catches up yo you, and roars menacingly loud. You take a stand and wait patiently for it to charge. It starts to come closer and you finally let the shell out of the barrel, finishing the beast off with a second shell just to be safe.");
                            Console.WriteLine("THE END... YOU WIN!");
                            break;
                    }
                }

                else if (Choice2 == "WAIT")
                {
                    Console.WriteLine("You wait for the figure to move, and it seems like forever until it does, and you slip and hit a twig. It turns around tremendously fast. You blink for a second and its gone like nothing was even there. You then feel something drip from above and are frozen from fear. Do you run or stand stil hoping for safety?");
                    Console.Write("Type STAY or RUN: ");
                    string Choice4 = Console.ReadLine();
                    Choice4 = Choice4.ToUpper();
                    Choice4.ToUpper();

                    if (Choice4 == "STAY")
                    {
                        Console.WriteLine("Why would you stay? That gave you like no chance..");
                        Console.WriteLine("THE END.");
                    }
                    else if (Choice4 == "RUN")
                    {
                        Console.WriteLine("You run as fast as you can to your campsite, but you forget if you have to take a left or a right... Which way?");
                        Console.WriteLine("Type LEFT or RIGHT");
                        string Choice5 = Console.ReadLine();
                        Choice4 = Choice5.ToUpper();
                        Choice5.ToUpper();

                        if (Choice4 == "LEFT")
                        {
                            Console.WriteLine("As you take the sharp left turn further into the forest, you start to realize this doesn't look too familiar. Whilst in your panic you trip on the root of a tree and the creature catches up to you...");
                            Console.WriteLine("THE END.");
                        }
                        else if (Choice4 == "RIGHT")
                        {
                            Console.WriteLine("You take a right and stumble back upon your campsite... as soon as you enter, you remember you have a gun in one of your tents but cant remember which one. Is it in the Red, Blue, or Green Tent?");
                            Console.Write("Type RED, BLUE, or GREEN: ");
                            string Choice3 = Console.ReadLine();

                            switch (Choice3)
                            {
                                case "RED":
                                    Console.WriteLine("You run to the tent and find that this contained your food supply. Too bad you'll also be food in a second...");
                                    Console.WriteLine("THE END.");
                                    break;

                                case "BLUE":
                                    Console.WriteLine("You run to the tent and find that this contained your clothes and bed. Unlucky choice...");
                                    Console.WriteLine("THE END");
                                    break;

                                case "GREEN":
                                    Console.WriteLine("You run to the tent and find that this contained your gun. You turn around and prep yourself to pull the trigger...");
                                    Console.WriteLine("The monster catches up yo you, and roars menacingly loud. You take a stand and wait patiently for it to charge. It starts to come closer and you finally let the shell out of the barrel, finishing the beast off with a second shell just to be safe.");
                                    Console.WriteLine("THE END... YOU WIN!");
                                    break;
                            }
                        }

                    }
                }
            }
        }
    }


