using System;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Employee[] emp = new Employee[3];
            for (int i = 0; i < 2; i++)
            {

                Console.WriteLine($"The ID of Employee No: {i + 1}");
                int id = int.TryParse(Console.ReadLine(), out int _id) ? _id : 0;

                Console.WriteLine($"The Salary of Employee No: {i + 1}");
                decimal salary = decimal.TryParse(Console.ReadLine(), out decimal _salary) ? _salary : 0;

                Console.WriteLine($"The Security Level of Employee No: {i + 1}");
                SecurityLevel securityLevel = SecurityLevel.TryParse(Console.ReadLine(), out SecurityLevel _securityLevel) ? _securityLevel : SecurityLevel.D;

                Console.WriteLine($"The Gender of Employee No: {i + 1}");
                Gender gender = Gender.TryParse(Console.ReadLine(), out Gender _gender) ? _gender : Gender.M;


                Console.WriteLine($"The Day of Hiring Employee No: {i + 1}");
                int day = int.TryParse(Console.ReadLine(), out int _day) ? _day : 1;

                Console.WriteLine($"The Month of Hiring Employee No: {i + 1}");
                int month = int.TryParse(Console.ReadLine(), out int _month) ? _month : 1;

                Console.WriteLine($"The Year of Hiring Employee No: {i + 1}");
                int year = int.TryParse(Console.ReadLine(), out int _year) ? _year : 2023;

                emp[i] = new Employee(id, salary, securityLevel, gender, new(day, month, year));


            }

            Array.Sort(emp);

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"The ID of Data of Employee No({i + 1}):");
                Console.WriteLine($"The Salary : {emp[i].ToString()}");
                Console.WriteLine($"The Security Level : {emp[i].getSecurityLevel()}");
                Console.WriteLine($"The Gender : {emp[i].GetGender()}");
                Console.WriteLine($"The Hiring Date : ({emp[i].hiredate.getday()}, {emp[i].hiredate.getmonth()}, {emp[i].hiredate.getyear()})");
                Console.WriteLine("****************************************************");

            }
        }
    }
}