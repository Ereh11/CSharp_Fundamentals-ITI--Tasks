using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal enum Gender { M, F }
    public enum SecurityLevel { A, B, C, D }
    internal struct Employee
    {
      
        int Id;
        decimal Salary;
        SecurityLevel SL;
        Gender G;
        public HireDate hiredate = new HireDate();
        public Employee(int Id, decimal Salary, SecurityLevel SL, Gender G, HireDate hd)
        {
            setID(Id);
            setSalary(Salary);
            setSecurityLevel(SL);
            setGender(G);
            hiredate = hd;
        }

        public void setID(int Id)
        {
            if (Id <= 0)
            {
                Console.WriteLine("ID Must be greater than Zero");
                this.Id = -1;
            }
            else
                this.Id = Id;
        }
        public int getID() => Id;
        public void setSalary(decimal Salary)
        {
            if (Salary <= 0)
            {
                Console.WriteLine("Salary Must be greater than Zero");
                this.Salary = 10_000;
            }
            else
                this.Salary = Salary;
        }

        public decimal getSalary() => Salary;
        public void setSecurityLevel(SecurityLevel SL) => this.SL = SL;

        public SecurityLevel getSecurityLevel() => SL;
        public void setGender(Gender G) => this.G = G;

        public Gender GetGender() => G;

        public override string ToString() => $"Employee with ID {getID()}, his salary: {String.Format("{0:C}", getSalary())}";

        
    }
    
}
