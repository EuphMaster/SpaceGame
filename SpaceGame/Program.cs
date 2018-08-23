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

            Console.WriteLine("Hello,Welcome to Earth", "\n");
            Console.WriteLine("Please name your Captain");
            string characterName = Console.ReadLine();




            Console.WriteLine("Welcome Captain  " + characterName);
            Console.WriteLine("You have been supplied with a Small Ugly Ship");
            bool a = true;

            do {
                Console.WriteLine("Where would you like to go? \n,Alpha Centauri or My Great Planet? \n" +
                "press A for Alpha Centauri   press B for My Great Planet");
            
                string userInput = Console.ReadLine();
                userInput = userInput.ToLower();
                
            
            
                if (userInput == "a")
                    
                {
                    Console.WriteLine("Good choice " + characterName + " your trip to Alpha Centauri will take");
                    a = false;

                    TravelDetails();
                }
                else if (userInput == "b")
                {
                    Console.WriteLine("Good choice " + characterName + " your trip to My Great Planet will take ");
                    a = false;
                }
                else
                {
                    Console.WriteLine("Input valid choice");
                     
                }
            }

            while (a == true);
                

            Console.ReadLine();
            Console.Clear();
        
            

        }
            

        public static void TravelDetails()

            
        {
            string choice;

            Console.WriteLine(" Congrats! You have arrived on the First stage of the game \n you will have to have some money to buy flight tickey" +
                " food and some other goodies");
            Console.WriteLine(" Look around there is nothing to do except go to the trading post.");
            Console.WriteLine(" You approach the store manager and he says");
            Console.WriteLine(" Hello! I have what you need, but first you have to give a correct answer to this question");

            Console.WriteLine(" Are you alive Yes or No?");
            Console.Write("choice ");

            choice = Console.ReadLine().ToLower();

            switch (choice)
            {
                case "Yes":
                case "No":
                    {
                        Console.WriteLine("You deserved ten thousands dollars!");
                        Console.WriteLine("You will not get any money,\n you have one more chance!");
                    }
                    
                    break;
            }

        }

    } 
   
    

}

