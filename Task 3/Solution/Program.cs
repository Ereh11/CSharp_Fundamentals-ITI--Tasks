using System.Text.RegularExpressions;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Read Data
            int size;
            do
            {
                Console.Write("Enter Number Of Empolyees: ");
            }
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0);

            Employee[] emp = new Employee[size];
            ReadData(ref emp);

            //Sort Array Based on Hiring Data
            Array.Sort(emp);
            //Display All Employees have same hiring date
            List<Employee> list = new List<Employee>();
            EmployeeSearch es = new EmployeeSearch(size);

            es.Employees = emp;
            list = es[5, 6, 2011];
            Console.WriteLine("Following Employees have the same Hiring date:");
            foreach (Employee e in list)
            {
                Console.WriteLine(e.ToString());
            }
            //Display All Employees have same Name
            es.Employees = emp;
            list = es["Ali"];

            Console.WriteLine("Following Employees have the same Name:");
            foreach (Employee e in list)
            {
                Console.WriteLine(e.ToString());
            }

            //Display All Employees based on ID
            Console.WriteLine("Data of Employee with id 156: ");
            Console.WriteLine(es[156].ToString());


            //Output Data
            for (int i = 0; i < emp?.Length; i++)
            {
                Console.WriteLine($"Data of Emplyee no. {i + 1}\n");
                Console.WriteLine(emp[i].ToString());
            }
        }
        static private void ReadData(ref Employee[] emp)
        {
            for (int i = 0; i < emp?.Length; i++)
            {
                Console.WriteLine($"Enter Data of Emplyee no. {i + 1}\n");

                int id, day, month, year;
                string name;
                decimal Salary;

                do
                {
                    Console.Write($"Enter The Employee ID: ");
                }
                while (!int.TryParse(Console.ReadLine(), out id));

                
                Console.Write($"Enter The Employee Name: ");
                name = Console.ReadLine() ?? "DEFAULT";
                

                do
                {
                    Console.Write($"Enter The Employee Salary: ");
                }
                while (!decimal.TryParse(Console.ReadLine(), out Salary));

                EnumDeclaretion.Gender g;
                do
                {
                    Console.Write($"Enter The Employee Gender: ");
                }
                while (!EnumDeclaretion.Gender.TryParse(Console.ReadLine(), out g));

                EnumDeclaretion.SecurityLevel sl;
                do
                {
                    Console.Write($"Enter The Employee Security Level: ");
                }
                while (!EnumDeclaretion.SecurityLevel.TryParse(Console.ReadLine(), out sl));

                do
                {
                    Console.Write($"Enter The Employee day Hiring: ");
                }
                while (!int.TryParse(Console.ReadLine(), out day));

                do
                {
                    Console.Write($"Enter The Employee month Hiring: ");
                }
                while (!int.TryParse(Console.ReadLine(), out month));

                do
                {
                    Console.Write($"Enter The Employee year Hiring: ");
                }
                while (!int.TryParse(Console.ReadLine(), out year));

                emp[i] = new Employee(id, name, Salary, new HiringDate(day, month, year), g, sl);
            }
        }
    }
}