using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class Program
    {

        static void Main(string[] args)
        {
            gameTitle();
            gameintroduction();
            characterName();
            aventureType();
            earthStore();
            
        }

        public static void gameTitle()       // first screen to show  when the game start.
        {
            Console.WriteLine("Hello, Welcome to this amazing game.");
            Console.WriteLine("Press 'Enter' to begin");
            Console.ReadLine();
            Console.Clear();

        }

        public static void gameintroduction()  // explain the context of the game 
        {
            Console.WriteLine("You are about to start an unforgettable adventure; You will travel" +
                " around the galaxy, have the opportunity" +
                " to trade 'buy and sell' commodities and hopefully make a profit if you are smart. " +
                "You will travel on two planets; " +
                "On each planet, you will have" +
                " a different set of products at different prices." +
                " Be smart! But, First, you will need a code name.");

            Console.WriteLine("Press 'Enter' to continue");
            Console.ReadLine();
            Console.Clear();
        }

        public static void characterName()    //     player choose a name 
        {
            string choice = " ";


            Console.WriteLine("At this stage, you have to choose your code name. Three choices are available for you: ");
            Console.WriteLine("I'm curious to see your choice!");
            Console.WriteLine("1.FlashLight");
            Console.WriteLine("2.Nasdaq");
            Console.WriteLine("3.Buzzor");
            Console.Write("choice: ");
            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "1":
                case "FlashLight":
                case "Flash":
                    {
                        Console.WriteLine("FlashLight! Great choice");
                        Console.WriteLine("Hopefully you will embody the meaning of the name");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();

                        break;
                    }

                case "2":
                case "Nasdaq":
                    {
                        Console.WriteLine("Nasdaq! perfect choice");
                        Console.WriteLine("You should be proud of yourself.");
                        Console.WriteLine("Press 'Enter to continue.");
                        Console.ReadLine();
                        break;
                    }

                case "3":
                case "Buzzor":
                    {
                        Console.WriteLine("Buzzor! That's  sweet");
                        Console.WriteLine("Robust choice.");
                        Console.WriteLine("Press 'Enter to continue.");
                        Console.ReadLine();
                        break;
                    }

                default:
                    {
                        Console.WriteLine("I dont understand that command...");
                        Console.WriteLine("Press 'Enter to try again.");
                        Console.ReadLine();
                        characterName();
                        break;
                    }

            }



        }
        public static void introAventureType()    // player pick his adventure type out of the two choices provide
        {



            Console.WriteLine(" Now the fun stuff start.");
            Console.WriteLine("Press 'Enter' to continue");
            Console.ReadLine();
            Console.Clear();


        }
        public static void aventureType()
        {
            string userInput = " ";

            Console.WriteLine("Rigt now, You have a two choices. Choose wisely and enjoy!");
            Console.WriteLine("A.Buy");
            Console.WriteLine("B.Travel");
            Console.Write("userInput: ");
            userInput = Console.ReadLine().ToLower();
            Console.Clear();

            switch (userInput)
            {
                case "a":
                    {
                        Console.WriteLine("You have chosen to buy");
                        Console.WriteLine("Press 'Enter' to continue");
                        Console.ReadLine();
                        earthStore();
                        break;
                    }
                case "b":
                    {
                        Console.WriteLine("You have chosen to travel");
                        Console.WriteLine("Press 'Enter' to continue");
                        Console.ReadLine();
                        break;

                    }
                default:
                    {
                        Console.WriteLine("That's an invalid choice...,Press 'Enter' to try again and this time pick 'A' or 'B'");
                        Console.ReadLine();
                        aventureType();
                        break;
                    }
            }



        }
        public static void earthStore()
        {
            string item;
            Console.WriteLine("Welcome to the Earth Store");
            Console.WriteLine("What would you like to buy? ");
            Console.WriteLine("Pick a number 1, 2, 3 or 4");
            Console.WriteLine("1- Pepsi = 3 credits");
            Console.WriteLine("2- Coke  = 4 credits ");
            Console.WriteLine("3 - Tab  = 17 credits");
            Console.WriteLine("4 - Faygo = 1 credit");
            item = Console.ReadLine().ToLower();
            Console.Clear();

            switch (item)
            {
                case "1":
                    {
                        Console.WriteLine("Good Choice");
                        Console.ReadLine();
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("Coke it is");
                        Console.ReadLine();
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("Tab is yummy");
                        Console.ReadLine();

                        break;
                    }
                case "4":
                    {
                        Console.WriteLine("Wow, you are cheap, enjoy your Faygo");
                        Console.ReadLine();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("I dont understand, try again");


                        break;
                    }


            }

        }
        public static void MyGreatStore()  // this is the implementation of the store in the earth location.
        {
            string item;
            Console.WriteLine("Welcome to My Great Planet Store");
            Console.WriteLine("What would you like to buy? ");
            Console.WriteLine("Pick a number 1, 2, 3 or 4");
            Console.WriteLine("1- Snickers = 12 credits");
            Console.WriteLine("2- KitKat   = 32 credits ");
            Console.WriteLine("3- Twix     = 23 credits");
            Console.WriteLine("4- BabyRuth = 5 credits");
            item = Console.ReadLine().ToLower();
            Console.Clear();

            switch (item)
            {
                case "1":
                    {
                        Console.WriteLine("Good Choice");
                        Console.ReadLine();
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("Yum KitKat");
                        Console.ReadLine();
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("Left and Right Twix, Yay");
                        Console.ReadLine();
                        break;
                    }
                case "4":
                    {
                        Console.WriteLine("Terrible candy bar, here you go");
                        Console.ReadLine();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("I dont understand, try again");
                        Console.ReadLine();
                        break;
                    }

            }


        }

        public static double travelTime(double W)      // this method will calculate the travel speed and years
        {
            double travelTime = 0;
            double distance = 0;
            
            travelTime = distance / (Math.Pow(W, 10 / 3) +
            Math.Pow(10 - W, -11 / 3));

            return travelTime;

        }

    }
}





