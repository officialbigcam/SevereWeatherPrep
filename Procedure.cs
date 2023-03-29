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
    // The below objects (my procedures) inherit their properties from the Procedure class
    // (Create a additional classes which inherit two properties from the parent class, Procedure)
    public class Procedure1 : Procedure
    {
        public Procedure1()
        {
            ProcedureNumber = 1;
            Task = "Ensure all entrances to your building and windows are closed";
        }


    }
        
    public class Procedure2 : Procedure
    {

        public Procedure2() 
        {
            ProcedureNumber = 2;
            Task = "Get underground. If no shelter or basement is available, get to the center-most point of the building you're in.";
        }
    }

    public class Procedure3 : Procedure
    {

        public Procedure3() 
        {
            ProcedureNumber = 3;
            Task = "Continue to monitor NOAA weather radio or the NOAA IOS/Android app for situational updates. Remain where you are.";
        }
    }
            
    public class SurvivabilityProcedure : Procedure
    {
              
        public List<Procedure> procedures = new List<Procedure>(); 
        public void ShowSurvivabilityProcedures()
        {
            Console.WriteLine("Now that all of your equipment is packed, please follow these safety procedures shown below\n");

            // Calls the ShowUserTheProcedure method for each procedure 
            var proc1 = new Procedure1();
            var proc2 = new Procedure2();
            var proc3 = new Procedure3();

            procedures.Add( proc1 );
            procedures.Add( proc2 );
            procedures.Add( proc3 );

            foreach (Procedure procedure in procedures)
            {
                procedure.ShowUserTheProcedure();
            }
        }
    }
}
