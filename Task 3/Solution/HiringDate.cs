using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public struct HiringDate

    {
        private int day, month, year;
        public HiringDate(int _day, int _month, int _year)
        {
            Day = _day;
            Month = _month;
            Year = _year;
        }
        public int Day 
        {
            set 
            {
                day = (value > 0 && value <= 31) ? value : 1;
            }
            get => day;
        }
        public int Month 
        {
            set
            {
                month = (value > 0 && value <= 12) ? value : 1;
            }
            get => month;
        }
        public int Year
        {
            set
            {
                year = (value > 1900 && value <= 2023) ? value : 2023;
            }
            get => year;
        }
    }
}
