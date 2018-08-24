﻿using System;
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

        }

        public static void gameTitle()          // first screen to show  when the game start.
        {
            Console.WriteLine("Hello, Welcome to this amazing game.");
            Console.WriteLine("Press 'Enter' to begin");
            Console.ReadLine();
            Console.Clear();

        }

        public static void gameintroduction()    // explain the context of the game 
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

        public static void characterName()       //     player choose a name 
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
        public static void aventureType()      // player choose with type of adventure to start with
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
                        EarthStore();
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


            }

        }
    }



}






