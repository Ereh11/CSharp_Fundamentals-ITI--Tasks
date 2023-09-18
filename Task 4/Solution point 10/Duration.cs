using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Duration
    {
        public Duration(int _hour, int _minute, int _second) : this(_second)
        {
            Hour = _hour;
            Hour += _minute / 60;
            _minute %= 60;
            Minute += _minute;
        }
        public Duration(int _second)
        {
            Hour += _second / 3600;
            _second %= 3600;
            Minute += _second / 60;
            _second %= 60;
            Second += _second;
        }

        public int Hour
        {
            set; get;
        }
        public int Minute
        {
            set; get;
        }
        public int Second
        {
            set; get;
        }

        public override string ToString()
        {
            string ans = "";
            if (Hour != 0)
                ans += $"Hours: {Hour}, ";

            if (ans.Contains("Hours") || Minute != 0)
                ans += $"Minutes : {Minute}, ";

            if (ans.Contains("Minutes") || Second != 0)
                ans += $"Seconds : {Second}";

            return (ans == "") ? "No Time Entered" : ans;
        }


        //Add and Substract
        public static Duration operator +(Duration a, Duration b) => new Duration(a.Hour + b.Hour, a.Minute + b.Minute, a.Second + b.Second);

        public static Duration operator -(Duration a, Duration b) => new Duration(a.Hour - b.Hour, a.Minute - b.Minute, a.Second - b.Second);
        
        public static Duration operator +(int Num, Duration a)
        {
            int hour = Num / 3600;
            Num %= 3600;
            int minute = Num / 60;
            Num %= 60;
            int second = Num;

            return new Duration(a.Hour + hour, a.Minute + minute, a.Second + second);
        }
        public static Duration operator -(int Num, Duration a)
        {
            int hour = Num / 3600;
            Num %= 3600;
            int minute = Num / 60;
            Num %= 60;
            int second = Num;

            return new Duration(a.Hour - hour, a.Minute - minute, a.Second - second);
        }
        //Postfix and Prefix

        public static Duration operator ++(Duration a) => new Duration(a.Hour, a.Minute + 1, a.Second);
        public static Duration operator --(Duration a) => new Duration(a.Hour, a.Minute - 1, a.Second);
        // Minus Operator
        public static Duration operator -(Duration a) => new Duration(-a.Hour, -a.Minute, -a.Second);


        //Comparsion
        public static bool operator >(Duration a, Duration b)
        {
            if (a.Hour != b.Hour)
                return a.Hour > b.Hour;
            else if (a.Minute != b.Minute)
                return a.Minute > b.Minute;
            return (a.Second > b.Second);
        }
        public static bool operator <(Duration a, Duration b)
        {
            if (a.Hour != b.Hour)
                return a.Hour < b.Hour;
            else if (a.Minute != b.Minute)
                return a.Minute < b.Minute;
            return (a.Second < b.Second);
        }
        public static bool operator >=(Duration a, Duration b) => a.Hour >= b.Hour;
        
        public static bool operator <=(Duration a, Duration b) => a.Hour <= b.Hour;

        //Equality
        public static bool operator !=(Duration a, Duration b) => (a.Hour != b.Hour) || (a.Minute != b.Minute) || (a.Second != b.Second);

        public static bool operator ==(Duration a, Duration b) => (a.Hour == b.Hour) && (a.Minute == b.Minute) && (a.Second == b.Second);

        // True or False
        public static bool operator true(Duration a) => (a.Hour != 0) || (a.Minute != 0) || (a.Second != 0);
        public static bool operator false(Duration a) => (a.Hour == 0) && (a.Minute == 0) && (a.Second == 0);

        //Implicit and Explicit For Duration and Integer

        public static implicit operator Duration(int Num)
        {
            int hour = Num / 3600;
            Num %= 3600;
            int minute = Num / 60;
            Num %= 60;
            int second = Num;

            return new Duration(hour, minute, second);
        }
        public static explicit operator int(Duration a) => a.Second + a.Minute * 60 + a.Hour * 3600;

        // Explicit For DateTime
        public static explicit operator DateTime(Duration a) => new DateTime(2023, 9, 18, a.Hour, a.Minute, a.Second);
        

    }
}
