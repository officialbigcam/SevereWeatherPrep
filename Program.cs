using System;
using SurvivabilityProceduresBaseAndChild;
using EquipmentToPack;
using MooreTornadoDate;


namespace SevereWeatherPrep

{
    public class Program 
    {
        public static void Main(string[] args)
        {

            //shows user how long it has been since the Moore EF5 tornado
            //It uses a simple mathematical equation and returns that number of years as a value 

            string currentDate = CurrentDate.GetCurrentDate();
            Console.WriteLine(currentDate);

            //the primary function of my app. Here the user can add, modify, show their equipment list or exit the program

            var equipmentList = new List<string>();
            Equipment.ListItems(equipmentList, "-finished", "-", "-show");

            Console.WriteLine("\n----Severe Weather Preparedness Bugout Bag Equipment Packing List----");
            foreach (var item in equipmentList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------\n");

            {
                //Please see Procedure class for how I made Procedure objects inherit from SurvivabilityProcedure
                //I created three different instances of the procedure object.
                //These procedures will be displayed in an ordered list
                //This happens when the user is finished checking/modifying their bugout bag list

                SurvivabilityProcedure procedures = new SurvivabilityProcedure();
                procedures.ShowSurvivabilityProcedures();

            }

        }
   
    }
}