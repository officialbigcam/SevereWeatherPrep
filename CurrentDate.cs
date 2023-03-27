using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MooreTornadoDate
{

    public class CurrentDate
    {
        public static string GetCurrentDate()
        {
            DateTime mooreTornado = new DateTime(2013, 05, 20);

            // this method calculates how many years it has been since the Moore, OK EF5 tornado.            
            // (Calculates and displays data based on an external factor)
            // (Calling this method returns a value, the result of how many years it has been since the Moore EF5)
            
            string result = DateTime.Now.ToString("h:mm:ss tt") + " - Is the current Time\n";
            result += mooreTornado.ToString() + " - Date of the Moore, OK EF5 Tornado\n";
            result += "it has only been " + (DateTime.Now.Year - mooreTornado.Year) + " years since the Moore EF5 tornado. Are you prepared?\n";

            return result;

        }
    }

}