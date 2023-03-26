using System;
using System.Collections.Generic;

namespace SurvivabilityProceduresBaseAndChild
{
    public class Procedure
    {
        public string Task;
        public int ProcedureNumber;

        public void ShowUserTheProcedure()
        {
            Console.WriteLine($"{ProcedureNumber}. {Task}");
        }
    }

    public class SurvivabilityProcedure : Procedure
    {
        // Creates a list of procedures for the SurvivabilityProcedures class
        // The below objects (my procedures) inherit their properties from the Procedure class

        public List<Procedure> procedures = new List<Procedure>
        {
            new Procedure
            {
                ProcedureNumber = 1,
                Task = "Ensure all entrances to your building and windows are closed"
            },
            new Procedure
            {
                ProcedureNumber = 2,
                Task = "Get underground. If no shelter or basement is available, get to the center-most point of the building you're in."
            },
            new Procedure
            {
                ProcedureNumber = 3,
                Task = "Continue to monitor NOAA weather radio or the NOAA IOS/Android app for situational updates. Remain where you are."
            }
        };

        public void ShowSurvivabilityProcedures()
        {
            Console.WriteLine("Now that all of your equipment is packed, please follow these safety procedures shown below\n");

            // Call the ShowUserTheProcedure method for each procedure in the list
            foreach (Procedure procedure in procedures)
            {
                procedure.ShowUserTheProcedure();
            }
        }
    }
}
