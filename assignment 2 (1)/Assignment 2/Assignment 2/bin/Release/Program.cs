using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class Program
    {
        static float finaltemp;

        static void Main(string[] args)
        {
            float temp;
            int conversion;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;

            var arr = new[]
            {
            @"   _____                                   _                    _____                           _            ",
            @"  |_   _|                                 | |                  /  __ \                         | |           ",
            @"    | | ___ _ __ ___  _ __   ___ _ __ __ _| |_ _   _ _ __ ___  | /  \/ ___  _ ____   _____ _ __| |_ ___ _ __ ",
            @"    | |/ _ \ '_ ` _ \| '_ \ / _ \ '__/ _` | __| | | | '__/ _ \ | |    / _ \| '_ \ \ / / _ \ '__| __/ _ \ '__|",
            @"    | |  __/ | | | | | |_) |  __/ | | (_| | |_| |_| | | |  __/ | \__/\ (_) | | | \ V /  __/ |  | ||  __/ |   ",
            @"    \_/\___|_| |_| |_| .__/ \___|_|  \__,_|\__|\__,_|_|  \___|  \____/\___/|_| |_|\_/ \___|_|   \__\___|_|   ",
            @"                     | |                                                                                     ",
            @"                     |_|                                                                                     ",           
            };
            Console.WindowWidth = 160;
            Console.WriteLine("\n\n");
            foreach (string line in arr)
                Console.WriteLine(line);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Press ENTER to start the Converter");
            Console.ReadKey();

            Console.WriteLine("");
            Console.WriteLine("TYPE 1 TO CONVERT A TEMPERATURE TO FAHRENHEIT");
            Console.WriteLine("TYPE 2 TO CONVERT A TEMPERATURE TO CELSIUS"); // this is where i ask the user which conversion they want to use
            Console.WriteLine("");
            Console.WriteLine("TYPE 3 TO GO TO THE HELP SCREEN");
            conversion = Convert.ToInt16(Console.ReadLine());

            if (conversion == 1)  // this part of the code determines which conversion they have selected
            {
                fahrenheit();
            }
            else if (conversion == 2) 
            {
                celsius();
            }
            else if (conversion == 3) 
            {
                Console.WriteLine("Type the temperature type you want to convert to, then enter the value of the temperature");
                Console.WriteLine("The converted temperature will then be outputted");
            }

            Console.ReadLine();

        }
        public static void fahrenheit() //this is the function responsible for converting a temperature from celsius to fahrenheit
        {
            
                float temp, finaltemp;
                Console.WriteLine("ENTER THE TEMPERATURE"); // this is where the program asks the user for the temperature value
                temp = Convert.ToSingle(Console.ReadLine());
                finaltemp = (9 / 5) * (temp + 32);

                Console.WriteLine("The temperature is {0}", finaltemp);
                Console.WriteLine("The original temperature was {0}", temp);
                
            
        }

        public static void celsius() //this is the function that is responsible for converting a temperature from fahrenheit to celsius
        {
                float temp, finaltemp;
                Console.WriteLine("ENTER THE TEMPERATURE");
                temp = Convert.ToSingle(Console.ReadLine());
                finaltemp = (5 / 9) * (temp - 32);

                Console.WriteLine("The temperature is {0}", finaltemp);
                Console.WriteLine("The original temperature was {0}", temp);
        }
    }
}
