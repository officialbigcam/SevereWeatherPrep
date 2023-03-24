using System;
using SurvivabilityProcedures;
using EquipmentToPack;
using MooreTornadoDate;


namespace SevereWeatherPrep

{
    public class Program 
    {
        public static void Main(string[] args)
        {


            CurrentDate.GetCurrentDate();

            Equipment.ListItems();


            {

                
                List<Procedure> procedures = new List<Procedure>();

                Procedure procedure1 = new Procedure();
                procedure1.ProcedureNumber = 1;
                procedure1.Task = ("Ensure all entrances to your building and windows are closed");

                Procedure procedure2 = new Procedure();
                procedure2.ProcedureNumber = 2;
                procedure2.Task = ("Get underground. If no shelter or basement is avaiable, get to the center-most point of the building you're in.");

                Procedure procedure3 = new Procedure();
                procedure3.ProcedureNumber = 3;
                procedure3.Task = ("Continue to monitor NOAA weather radio or the NOAA IOS/Android app for situational updates. Remain where you are.");

                Console.WriteLine("Now that all of your equipment is packed, please follow these safety procedures shown below\n");
                Console.WriteLine(procedure1.ProcedureNumber + procedure1.Task);
                Console.WriteLine(procedure2.ProcedureNumber + procedure2.Task);
                Console.WriteLine(procedure3.ProcedureNumber + procedure3.Task);

                 
                
            }
                
                

            



            
        }
    }
}
