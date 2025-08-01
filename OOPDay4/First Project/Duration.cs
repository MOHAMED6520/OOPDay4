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
        public Duration(int hours , int minutes , int seconds)
        {
            if (seconds >= 60)
            {
                _minutes= seconds /60;
                seconds = seconds %60;
                
            }
            Seconds = seconds;
            minutes = minutes + _minutes;

            if (minutes >= 60)
            {
                _hours= minutes /60;
                minutes = minutes % 60;
                
            }
            Minutes = minutes;
            Hours = hours+_hours;
        }

        public Duration (int seconds)
        {
            if (seconds >= 60)
            {
                _minutes=seconds /60;
                seconds = seconds % 60;
                
            }
            Seconds = seconds;

            if (_minutes >=60)
            {
                _hours = _minutes / 60;
                _minutes = _minutes % 60;
                
            }
            Minutes=_minutes;

            Hours=_hours;
        }
      
        public Duration()
        {
            
        }

        public override string ToString()
        {
            if (Hours == 0)
                {
                if (Minutes == 0)
                    return $"Seconds : {Seconds}";
                else
                    return $"Minutes : {Minutes}, Seconds : {Seconds}";
            }
            else
                return $"Hours: {Hours} , Minutes : {Minutes}, Seconds : {Seconds}";
        }
    }
}
