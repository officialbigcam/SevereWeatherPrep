using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace SurvivabilityProcedures

{
    public class Procedure
    {
       
        //This is a simple way to display procedures after the equipment list has been finished. 
        //Below are the two properties I chose for the object.
        //I created three different instances of the procedure object.
        //(Basically, just 3 steps that help the user not die.             
        //see my program class where I called the ShowUserTheProcedure method.
        //No Tornado's gonna get us now!!
            
        public string Task;
        public int ProcedureNumber;

        public void ShowUserTheProcedure()
        {
            
            Console.WriteLine($"{ProcedureNumber}. {Task}");
            
        }
    }
}
