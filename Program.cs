using System;
using SurvivabilityProcedures;
using EquipmentToPack;


namespace SevereWeatherPrep

{
    public class Program 
    {
        public static void Main(string[] args)
        {

            CurrentDate.GetCurrentDate();
            //^This function is the last one we need to figure out to meet project requirements!
            //Work with Tom to figure that calculation out. Also ask Reddit, people on Slack, etc
            Equipment.ListItems();

            Procedures.SurvivalProcedures();
            
        }
    }
}
