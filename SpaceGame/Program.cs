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

            
            

        }
        







    }
    

}

