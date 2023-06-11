using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    enum Gender : byte
    {
        M, F
    }

    enum SecurityLevl : byte
    {
        guest, developer, secretary, DBA
    }
    internal struct Employee : IComparable
    {
        private int _ID;
        private Gender _Gender;
        private HiringDate _HiringDate;
        private decimal _Salary;
        private SecurityLevl _SecurityLevl;

        public Employee(int id, Gender gender, HiringDate hd, decimal salary, SecurityLevl sl)
        {
            _ID = id;
            _Gender = gender;
            _HiringDate = hd;
            _Salary = salary;
            _SecurityLevl = sl;
        }

        public int ID
        {
            set => _ID = (value < 0) ? 99999 : value;
            get => _ID;
        }

        public decimal Salary
        {
            set => _Salary = (value <= 0) ? 15000 : value;
            get => _Salary;
        }

        public int CompareTo(object? obj)
        {
            if (obj is Employee other)
            {

                if (other._HiringDate.Day != _HiringDate.Day)
                    return _HiringDate.Day.CompareTo(other._HiringDate.Day);

                if (other._HiringDate.Month != _HiringDate.Month)
                    return _HiringDate.Month.CompareTo(other._HiringDate.Month);

                return _HiringDate.Year.CompareTo(other._HiringDate.Year);
            }

            return 1;
        }

        public override string ToString()
        {
            return $"Empolyee ID: {_ID}\nSalary: {String.Format("{0:C}", _Salary)}\nGender: {_Gender}\nHiring Date: {_HiringDate.Day} {_HiringDate.Month} {_HiringDate.Year}";
        }
    }
}
