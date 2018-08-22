using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    public static class Game
    {


        static string CharacterName = " ";

        public static void StartGame()
        {
            Console.WriteLine("SpaceGame");
            Console.WriteLine("Welcome to our great adventure. You are about to travel the Galaxy!");
            string CharacterName;
            Choice();
        }
        static void Choice()
        {
            string input = " ";
            Console.WriteLine(CharacterName + " Which Planet would you Choose?\n My great planet or Alpha centauri? ");
            input = Console.ReadLine();
            if (input == "My great planet")
            {
                Console.WriteLine("You have choosen My great Planet!");
            }
            else
            {
                Console.WriteLine("You have choosen Apha centauri!");
            }

        }
        static void CharacterNAme()
        {
            Console.WriteLine("What would like your character name to be? ");
            CharacterName = Console.ReadLine();

            Console.WriteLine("Great your code name is now Named " + CharacterName);
        }
    }
    class item
    {

    }
    class program

    { 
           static void Main()
           {
            Game.StartGame();
            Console.WriteLine();

           }
    }
}              



