

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] emp = new Employee[3];

            // Read Data From End-User.
            for(int i = 0; i < emp?.Length; i++)
            {
                Console.WriteLine($"Data Of Use No. {i + 1}");
                int id, day, month, year;
                Gender gndr;
                decimal salary;
                SecurityLevl sl;
                do
                {
                    Console.WriteLine($"Enter User ID: ");
                }
                while (!int.TryParse(Console.ReadLine(), out id));

                do
                {
                    Console.WriteLine($"Enter User Salary: ");
                }
                while (!decimal.TryParse(Console.ReadLine(), out salary));

                do
                {
                    Console.WriteLine($"Enter User Gender No.{i + 1}: ");
                }
                while (!Gender.TryParse(Console.ReadLine(), out gndr));

                do
                {
                    Console.WriteLine($"Enter User Hiring Date day: ");
                }
                while (!int.TryParse(Console.ReadLine(), out day));

                do
                {
                    Console.WriteLine($"Enter User Hiring Date month: ");
                }
                while (!int.TryParse(Console.ReadLine(), out month));

                do
                {
                    Console.WriteLine($"Enter User Hiring Date year: ");
                }
                while (!int.TryParse(Console.ReadLine(), out year));

                do
                {
                    Console.WriteLine($"Enter User Security Level: ");
                }
                while (!SecurityLevl.TryParse(Console.ReadLine(), out sl));

                emp[i] = new Employee(id, gndr, new HiringDate(day, month, year), salary, sl);
            }



            // Sort Array Base on Hiring Date.
            if (emp is not null)
                Array.Sort(emp);

            for(int i = 0; i < emp?.Length; i++)
            {
                // Print Data Of End-Users.
                Console.WriteLine($"The following Data of Employeee No. {i + 1}");
                Console.WriteLine(emp[i].ToString());
            }
        }
    }
}