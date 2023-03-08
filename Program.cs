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
            Equipment.ListItems();
            Procedures.SurvivalProcedures();
            
        }
    }
}
