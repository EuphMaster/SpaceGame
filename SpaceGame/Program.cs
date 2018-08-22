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
            Console.WriteLine("Where would you like to go? \n,Alpha Centauri or My Great Planet? \n" +
                "press A for Alpha Centauri   press B for My Great Planet");

            string userInput = Console.ReadLine();
            userInput = userInput.ToLower();

            do
            {
                if (userInput == "a")

                {
                    Console.WriteLine("Good choice " + characterName + " your trip to Alpha Centauri will take");
                }
                else if (userInput == "b")
                {
                    Console.WriteLine("Good choice " + characterName + " your trip to My Great Planet will take ");
                }
                else
                {
                    Console.WriteLine("Input valid choice");
                }
            } while (bool = );



            Console.ReadLine();
           
        }
       


    }

}

