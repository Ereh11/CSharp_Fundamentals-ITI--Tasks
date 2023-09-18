using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Point3D : IComparable, ICloneable
    {
        private int x, y, z;

        public Point3D(Point3D OldObj)
        {
            x = OldObj.x;
            y = OldObj.y;
            z = OldObj.z;
        }
        public Point3D(int _x, int _y)
        {
            x = _x;
            y = _y;
            z = 0;
        }
        public Point3D(int _x, int _y, int _z) : this(_x, _y)
        {
            z = _z;
        }

        public override string ToString()
        {
            return $"Point Coordinates: ({x}, {y}, {z})";
        }

        public override bool Equals(object? obj)
        {
            if (obj is Point3D p)
            {
                if (x == p.x && y == p.y && z == p.z)
                    return true;
                else
                    return false;
            }
            else 
                return false;
        }

        public int CompareTo(object? obj)
        {
            if (obj is Point3D p)
            {
                if (p.x == x)
                    return p.y.CompareTo(y);
                else
                    return p.x.CompareTo(x);
            }
            else
                return 1;
        }

        public object Clone()
        {
            return new Point3D(this);
        }
    }
}
