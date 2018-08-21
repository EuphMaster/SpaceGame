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

            Console.WriteLine("Hello,Welcome to Space Station Braggadamia", "\n");
            Console.WriteLine("Please name your Captain");
            string characterName = Console.ReadLine();

            Console.WriteLine("Welcome Captain  " + characterName);
            Console.WriteLine("Please Choose a ship \n press A or B");
            Console.WriteLine("A - Small ugly ship with minimal power " +
                              "\nB - Tiny cute ship with minimal power");



            Console.ReadLine();
        }
    }

}

