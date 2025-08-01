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

            if (seconds <0 )
               {
                if (minutes <= 0)
                {
                    hours = hours - 1; 
                    minutes = minutes+59;
                    seconds = seconds + 60;
                }
                else
                {
                    minutes = minutes -1;
                    seconds = seconds + 60;
                }
               }

            if (minutes < 0)
            {
                hours = hours - 1;
                minutes = minutes + 60;
                
            }

            if (hours < 0 )
             {
                hours = 0; 
                minutes = 0;
                seconds = 0;
             }
                

            return $"Hours: {hours} , Minutes : {minutes}, Seconds : {seconds}";
        }

        public static Duration operator +(Duration a, Duration b)
        {
            return new Duration()
            {
                Hours = a.Hours + b.Hours,
                Minutes = a.Minutes + b.Minutes,
                Seconds = a.Seconds + b.Seconds
            };
        }

        public static Duration operator +(Duration a, int b)
        {
            return new Duration()
            {
              Seconds=a.Seconds + b,
              Minutes=a.Minutes ,
              Hours = a.Hours ,
              
            };
        }

        public static Duration operator +(int b, Duration a)
        {
            return new Duration()
            {
                Seconds = a.Seconds + b,
                Minutes = a.Minutes,
                Hours = a.Hours,
            };
        }

        public static Duration operator ++(Duration D)
        {
            D.Minutes++;
            return new Duration () 
            {
                Seconds = D.Seconds ,
                Minutes = D.Minutes,
                Hours =   D.Hours,
            };
        }

        public static Duration operator --(Duration D)
        {
            D.Minutes--;
            return new Duration()
            {
                Seconds = D.Seconds,
                Minutes = D.Minutes,
                Hours = D.Hours,
            };
        }

        public static Duration operator -(Duration a, Duration b)
        {
            return new Duration()
            {
                Hours = a.Hours - b.Hours,
                Minutes = a.Minutes - b.Minutes,
                Seconds = a.Seconds - b.Seconds
            };
        }

        public static bool operator >(Duration left , Duration right)
        {
            if (left.Hours == right.Hours)
            {
                if (left.Minutes == right.Minutes)
                    return left.Seconds > right.Seconds;
                else
                    return left.Minutes > right.Minutes;
            }
            else 
                return left.Hours > right.Hours;
        }

        public static bool operator <(Duration left, Duration right)
        {
            if (left.Hours == right.Hours)
            {
                if (left.Minutes == right.Minutes)
                    return left.Seconds < right.Seconds;
                else
                    return left.Minutes < right.Minutes;
            }
            else
                return left.Hours < right.Hours;
        }


        public override string ToString()
        {
            return CalcDUration (Hours, Minutes, Seconds);
        }
    }
}
