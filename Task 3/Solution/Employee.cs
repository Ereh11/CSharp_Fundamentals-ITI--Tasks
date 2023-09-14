using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Employee : IComparable
    {
        private decimal salary;
        public int ID { set; get;}
        public string Name { set; get;}
        public decimal Salary 
        { 
            set
            {
                salary = (value < 0) ? 15000 : value;
            }
            get => salary;
        }
    
        public HiringDate hiringdate;

        EnumDeclaretion.Gender gender;

        EnumDeclaretion.SecurityLevel securitylevel;

        public Employee() { }
        public Employee(int _id, string _name, decimal _salary, HiringDate _hiringdate, EnumDeclaretion.Gender _gender, EnumDeclaretion.SecurityLevel _securitylevel)
        {
            ID = _id;
            Name = _name;
            Salary = _salary;
            hiringdate = _hiringdate;
            gender = _gender;
            securitylevel = _securitylevel;
        }

        string ShowHiringDate()
        {
            string ans;
            ans = (hiringdate.Day >= 10 ? hiringdate.Day.ToString() : "0" + hiringdate.Day) + '-' +
                (hiringdate.Month >= 10 ? hiringdate.Month.ToString() : "0" + hiringdate.Month) + '-'
             + hiringdate.Year;

            return ans;
        }
        public override string ToString()
        {
            return $"Employee ID: {ID}\nName: {Name}\nSalary: {String.Format("{0:C}", Salary)}\nGender: {gender}\n" +
                $"Security Level: {securitylevel}\nHiring Date: {ShowHiringDate()}\n";
        }

        public int CompareTo(object? obj)
        {
            if (obj is Employee other)
            {

                if (other.hiringdate.Day != hiringdate.Day)
                    return hiringdate.Day.CompareTo(other.hiringdate.Day);

                if (other.hiringdate.Month != hiringdate.Month)
                    return hiringdate.Month.CompareTo(other.hiringdate.Month);

                return hiringdate.Year.CompareTo(other.hiringdate.Year);
            }
            return 1;
        }
    }
}
