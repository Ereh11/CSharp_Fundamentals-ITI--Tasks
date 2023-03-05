using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal struct HireDate
    {
        int day;
        int month;
        int year;
        public HireDate(int day, int month, int year)
        {
            setday(day);
            setmonth(month);
            setyear(year);
        }

        public void setday(int day)
        {
            if (day <= 0 || day > 31)
                this.day = 1;
            else
                this.day = day;
        }
        public int getday() => this.day;
        public void setmonth(int month)
        {
            if (month <= 0 || month > 12)
                this.month = 1;
            else
                this.month = month;
        }
        public int getmonth() => this.month;
        public void setyear(int year)
        {
            if (year <= 0 || year > 2023)
                this.year = 2023;
            else
                this.year = year;
        }
        public int getyear() => this.year;

    }
}
