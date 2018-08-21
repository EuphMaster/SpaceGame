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
            string CharacterName = Console.ReadLine();




            Console.WriteLine("Welcome Captain  " + CharacterName);
            Console.WriteLine("You have been supplied with a Small Ugly Ship");
            Console.WriteLine("Where would you like to go?", "\n", "Alpha Centauri or My Great Planet?");
            string Earth = Console.ReadLine();
            Console.ReadLine();
           
        }
       


    }

}

