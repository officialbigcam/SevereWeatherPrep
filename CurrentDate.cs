using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevereWeatherPrep
{
    internal class CurrentDate
    {

        public static void GetCurrentDate()
        {
            DateTime mooreTornado = new DateTime(2013, 05, 20);

            //lets the user know how many years it has been since the Moore, OK EF5 tornado on May 20th 2013

            Console.WriteLine(DateTime.Now.ToString("h:mm:ss tt") + " - Is the current Time\n");
            Console.WriteLine(mooreTornado.ToString() + " - Date of the Moore, OK EF5 Tornado\n");
            Console.WriteLine("it has only been " + (DateTime.Now.Year - mooreTornado.Year) + " years since the Moore EF5 tornado. Are you prepared?\n");

            //(EndDate - StartDate).TotalDays
            
        }
    }
}
