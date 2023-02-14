using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentToPack
{
    public class Equipment
    {
        public static void ListItems()
        {
            var EquipmentList = new List<string>();
            var appRunning = true;
            //Give user program instructions 
            Console.WriteLine("Welcome to the Severe Weather Prep application");
            Console.WriteLine("Commands: '-Exit', '-Show', '-' \n");
            //As long as user does not exit the program, do this:
            while (appRunning == true)

            {
                Console.WriteLine("Please enter equipment to add or a command to perform:");

                //read in what the user types
                var input = Console.ReadLine();

                switch (input)

                {

                    //if told to exit, close program
                    case string a when a.StartsWith("-Exit"):
                        break;

                    //if told to remove a piece of equipment, remove it
                    case string b when b.EndsWith("-"):
                        break;

                    //if told to show the list of equipment, show it
                    case string c when c.StartsWith("show"):
                        break;

                    //if none of these commands are given, add whatever the user typed to the list of equipment
                    default:
                        break;

                }

            }

        }
    }

}