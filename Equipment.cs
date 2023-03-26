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
        public static void ListItems(List<string> equipmentList, string exitCommand = "-finished", string removeCommand = "-", string showCommand = "-show")
        {
            //Gives user program instructions 
            Console.WriteLine("----Welcome to the Severe Weather Prep application----\n");
            Console.WriteLine("----Please type the equipment items you intend to pack in your emergency kit, I.E. Flashlight, road flares, etc----\n");
            Console.WriteLine($"Type '{showCommand}' to double check your equipment, '{removeCommand}' to remove an item, or '{exitCommand}' when ready to view procedures \n");

            while (true)
            {
                Console.WriteLine("Please take account of all bugout bag equipment and add it below. This is your equipment checklist\n");

                var input = Console.ReadLine();

                if (input.StartsWith(exitCommand))
                {
                    break;
                }
                else if (input.EndsWith(removeCommand))
                {
                    var endIndex = input.IndexOf(removeCommand);
                    var item = input.Substring(0, endIndex);
                    if (equipmentList.Contains(item))
                    {
                        equipmentList.Remove(item);
                        Console.WriteLine($"Removed {item} \n");
                    }
                    else
                    {
                        Console.WriteLine($"{item} is not currently in the equipment list and can't be removed.");
                    }
                }
                else if (input.StartsWith(showCommand))
                {
                    Console.WriteLine("\n----Severe Weather Preparedness Bugout Bag Equipment Packing List----");
                    foreach (var task in equipmentList)
                    {
                        Console.WriteLine(task);
                    }
                    Console.WriteLine("--------------\n");
                }
                else
                {
                    equipmentList.Add(input);
                }
            }
        }

    }
}
