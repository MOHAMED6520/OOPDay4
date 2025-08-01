using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDay4.First_Project
{
    internal class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        private int _hours = 0 , _minutes = 0  , _seconds =0 ;
        public Duration(int hours, int minutes, int seconds) : this(seconds)
        {
            Hours = hours;
            Minutes = minutes;

        }

        public Duration(int seconds)
        {
            Seconds = seconds;
        }
        public Duration()
        {

        }
        private string CalcDUration(int hours, int minutes, int seconds)
        {
            if (seconds >= 60)
            {
                _minutes = seconds / 60;
                seconds = seconds % 60;

            }
          
            minutes = minutes + _minutes;

            if (minutes >= 60)
            {
                _hours = minutes / 60;
                minutes = minutes % 60;

            }
            Minutes = minutes;
           
            hours = hours + _hours;

            return $"Hours: {hours} , Minutes : {minutes}, Seconds : {seconds}";
        }
 
      

        public override string ToString()
        {
            return CalcDUration (Hours, Minutes, Seconds);
        }
    }
}
