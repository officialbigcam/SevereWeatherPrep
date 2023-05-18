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
            // shows user how long it has been since the Moore EF5 tornado
            // it uses a simple mathematical equation and returns that number of years as a value 

            string currentDate = CurrentDate.GetCurrentDate();
            Console.WriteLine(currentDate);

            
            var exit = false;
            var equipmentList = new List<string>();
            SurvivabilityProcedure procedures = new SurvivabilityProcedure();

            //The primary function of my app. Here the user can add, modify, show their equipment list, start over, or exit the program.
            //This includes the master loop.
            //It gives the user the ability to clear and go back to their bugout kit list, or to exit the program
            //If the user choses to exit the program, SurvivabilityProcedures will be displayed

            while (!exit)
            {
                Equipment.ListItems(equipmentList, "-finished", "-", "-show");

                Console.WriteLine("\n----Severe Weather Preparedness Bugout Bag Equipment Packing List----");
                foreach (var item in equipmentList)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("--------------\n");

                Console.WriteLine("0 - Exit the application");
                Console.WriteLine("1 - Reset your equipment list and go back");
                var input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 0:
                        exit = true;
                        procedures.ShowSurvivabilityProcedures();
                        break;

                    case 1:
                        equipmentList.Clear();
                        break;
                }
            }
        }
    }
}