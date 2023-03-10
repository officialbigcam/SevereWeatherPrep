using SurvivabilityProcedures;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentToPack
{
    public class Equipment : Procedures
    {
        public static void ListItems()
        {
            var EquipmentList = new List<string>();
            var appRunning = true;
            //Gives user program instructions 
            Console.WriteLine("----Welcome to the Severe Weather Prep application----\n");
            Console.WriteLine("----Please type the equipment items you intend to pack in your emergency kit, I.E. Flashlight, road flares, etc----\n");
            Console.WriteLine("Type '-show' to view your equipement, '-' to remove an item, or '-exit' when ready to view procedures \n");
            
            while (appRunning == true)

            {
                Console.WriteLine("Please take account of all bugout bag equipment and add it below. This is your equipment checklist\n");
               
               
                var input = Console.ReadLine();



                switch (input)

                {

                    
                    case string a when a.StartsWith("-exit"):
                        appRunning = false;
                        break;

                    //if told to remove a piece of equipment, remove it
                    case string b when b.EndsWith("-"):
                        var endIndex = b.IndexOf("-");
                        var item = b.Substring(0, endIndex);
                        if (EquipmentList.Contains(item))
                        {
                            EquipmentList.Remove(item);
                            Console.WriteLine("Removed {0} \n", item);
                        }

                        else

                        {
                            Console.WriteLine("{0} is not currently in the equipment list and can't be removed.", item);
                        }
                        break;

                    //if told to show the list of equipment, show it
                    case string c when c.StartsWith("-show"):
                        Console.WriteLine("\n----Severe Weather Prepardness Bugout Bag Equipment Packing List----");
                        foreach (var task in EquipmentList)
                        {
                            Console.WriteLine(task);
                        }
                        Console.WriteLine("--------------\n");
                        break;
                   
                        
                      
                    //if none of these commands are given, add whatever the user typed to the list of equipment
                    default:
                        EquipmentList.Add(input);
                        break;

                }
            }

        }


    }
}