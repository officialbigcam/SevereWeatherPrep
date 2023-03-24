using System;
using SurvivabilityProcedures;
using EquipmentToPack;
using MooreTornadoDate;


namespace SevereWeatherPrep

{
    public class Program : Procedure
    {
        public static void Main(string[] args)
        {

            //shows user how long it has been since the Moore EF5 tornado and also displays current time
            CurrentDate.GetCurrentDate();

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

                //The procedures that are displayed to the user after they've finished packing their gear.
                //When they chose to exit the program, these procedures will be displayed in an ordered list.
                //I called ShowUserTheProcedure method below to do this. 
                

                List<Procedure> procedures = new List<Procedure>();

                Procedure procedure1 = new Procedure();
                procedure1.ProcedureNumber = 1;
                procedure1.Task = "Ensure all entrances to your building and windows are closed";

                Procedure procedure2 = new Procedure();
                procedure2.ProcedureNumber = 2;
                procedure2.Task = "Get underground. If no shelter or basement is avaiable, get to the center-most point of the building you're in.";

                Procedure procedure3 = new Procedure();
                procedure3.ProcedureNumber = 3;
                procedure3.Task = "Continue to monitor NOAA weather radio or the NOAA IOS/Android app for situational updates. Remain where you are.";

                procedures.Add(procedure1);
                procedures.Add(procedure2);
                procedures.Add(procedure3);

                Console.WriteLine("Now that all of your equipment is packed, please follow these safety procedures shown below\n");

                foreach (Procedure procedure in procedures)
                {
                    procedure.ShowUserTheProcedure();
                }

            }

        }
    }
}