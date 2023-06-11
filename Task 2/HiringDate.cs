using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal struct HiringDate
    {
        private int _Day, _Month, _Year;
        public HiringDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public int Day
        {
            set
            {
                if (value > 0 && value <= 31)
                    _Day = value;
                else
                    _Day = 1;
            }
            get => _Day;
        }

        public int Month
        {
            set
            {
                if(value > 0 && value <= 12)
                    _Month = value;
                else
                    _Month = 1;
            }
            get => _Month;
        }

        public int Year
        {
            set
            {
                if (value > 2000 && value <= 2023)
                    _Year = value;
                else
                    _Year = 2023;
            }
            get => _Year;
        }
    }
}
