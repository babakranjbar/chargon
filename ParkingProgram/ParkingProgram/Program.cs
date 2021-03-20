using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkingProgram;

namespace ParkingProgram
{
    class Program

    {
        

        static void MainMenu()
        {
            Console.WriteLine("******************************");
            Console.WriteLine("Parking System Program");
            Console.WriteLine("******************************");
            Console.WriteLine("1. Add vehicle");
            Console.WriteLine("2. Remove vehicle");
            Console.WriteLine("q. Quit");
        }
        static void Main(string[] args)
        {

            MainMenu();
            string input = Console.ReadLine();
            if (input == "1")
            {
                Console.WriteLine("******************************");
                Console.WriteLine("Add vehicle");
                Console.WriteLine("******************************");
                Console.WriteLine("1. car  ");
                Console.WriteLine("2. bike");
                string input2 = Console.ReadLine();
                if (input2 == "1")
                {
                    Car cars = new Car();
                }
                




            }
            else if (input == "2")
            {
                Console.WriteLine("2");
            }
            else if (input == "q" | input == "Q")
            {
                System.Environment.Exit(0);
            }
        }
    }
}
