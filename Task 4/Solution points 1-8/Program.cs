namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Task point 1, 2
            Point3D Region1_p1 = new Point3D(1, 2);
            Console.WriteLine(Region1_p1.ToString());
            Point3D Region1_p2 = new Point3D(5, 7, -30);
            Console.WriteLine(Region1_p2.ToString());

            string s = Region1_p2.ToString();
            Console.WriteLine(s);
            #endregion

            #region Task point 3, 4
            int x, y, z;
            Point3D Region2_p1, Region2_p2;

            Console.WriteLine("Enter x, y, z of Point 1: ");
            ReadUser(out x, out y, out z);
            Region2_p1 = new Point3D(x, y, z);

            Console.WriteLine("Enter x, y, z of Point 2: ");
            ReadUser(out x, out y, out z);
            Region2_p2 = new Point3D(x, y, z);

            Console.WriteLine(Region2_p1);
            Console.WriteLine(Region2_p2);

            if (Region2_p1 == Region2_p2)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");

            if (Region2_p1.Equals(Region2_p2))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
            #endregion

            #region Task point 5
            Point3D[] arr = new Point3D[4];
            for (int i = 0; i < arr?.Length; i++)
            {
                Console.WriteLine($"Enter Data of point {i + 1}: ");
                int Region3_x, Region3_y, Region3_z;
                ReadUser(out Region3_x, out Region3_y, out Region3_z);
                arr[i] = new Point3D(Region3_x, Region3_y, Region3_z);
            }

            //Sorted Based on x, y
            Array.Sort(arr);
            for (int i = 0; i < arr?.Length; i++)
            {
                Console.WriteLine(arr[i].ToString());
            }
            #endregion

            #region Task point 6
            //Implement Icloneable
            Point3D Region4_p1 = new Point3D(6, -13, 5);
            Point3D Region4_p2 = (Point3D)Region4_p1.Clone();
            Console.WriteLine($"p1: {Region4_p1.ToString()} {Region4_p1.GetHashCode()}");
            Console.WriteLine($"p2: {Region4_p2.ToString()} {Region4_p2.GetHashCode()}");
            #endregion

            #region Task point 7, 8
            //Implement Math Class
            Console.WriteLine(Math.Add(5, 1));
            Console.WriteLine(Math.Subtact(5, 1));
            Console.WriteLine(Math.Multiply(5, 6));
            Console.WriteLine(Math.Divide(6, 3)); 
            #endregion
        }

        static void ReadUser(out int x, out int y, out int z)
        {
            Console.Write($"X: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Y: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Z: ");
            z = Convert.ToInt32(Console.ReadLine());
        }
    }
}