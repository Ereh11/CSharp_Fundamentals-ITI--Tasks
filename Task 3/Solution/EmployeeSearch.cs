using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class EmployeeSearch
    {
        public Employee[] Employees;
        private static int SizeIndx = 0;
        private int Size;

        public EmployeeSearch(int size)
        {
            Size = size;
            Employees = new Employee[size];
        }

        void IncreaseArrayEmployees()
        {
            Employee[] emp = new Employee[Size * 2];
            for (int i = 0; i < Size; i++)
            {
                emp[i] = Employees[i];
            }
            Employees = emp;
        }
       
        public Employee this[int id]
        {
            get
            {
                foreach (Employee emp in Employees)
                {
                    if (emp.ID == id) 
                        return emp;
                }
                return new Employee();
            }
        }
        public List<Employee> this[string name]
        {
            get
            {
                List<Employee> lt = new List<Employee>();
                foreach (Employee emp in Employees)
                {
                    if (emp.Name == name)
                        lt.Add(emp);
                }
                return lt;
            }
        }
        
        public List<Employee> this[int day, int month, int year]
        {
            get
            {
                List<Employee> lt = new List<Employee>();
                foreach (Employee emp in Employees)
                {
                    if (emp.hiringdate.Day == day && emp.hiringdate.Month == month && emp.hiringdate.Year == year)
                        lt.Add(emp);
                }
                return lt;
            }
        }
    }
}
