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

            Console.WriteLine(mooreTornado.ToString() + " - This is the date of the Moore, OK EF5 Tornado\n"); 

            Console.WriteLine(DateTime.Now.ToString("h:mm:ss tt") + " - Is the current Time\n");

            Console.WriteLine((mooreTornado.Day - DateTime.Now.Day) + " " + mooreTornado.Day);

            //(EndDate - StartDate).TotalDays
            //however if you would like only WHOLE days as an int and are happy to forgo the time component of the date then consider:
            //(EndDate.Date - StartDate.Date).Days

            //I Want it to say "It has been __ days since the Moore, OK Tornado (mooreTornado variable). EF5 tornados have appeared more frequently with climate change. Are you prepared?"
            //Need to figure out how to count days in between now and Moore Tornado


            //^^^Need to find out how to format this calculation with proper syntax 
            //Console.WriteLine and wrap it around the calculation with curly braces and see what it displays.

        }
    }
}
