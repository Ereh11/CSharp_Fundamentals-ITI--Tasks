using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Complex
    {

        public int Real { set; get; }
        public double Img { set; get; }
        
        // Basic Operation
        public static Complex operator +(Complex a, Complex b)=> new Complex() { Real = a.Real + b.Real, Img = a.Img + b.Img };
        public static Complex operator -(Complex a, Complex b) => new Complex() { Real = a.Real - b.Real, Img = a.Img - b.Img };
        public static Complex operator *(Complex a, Complex b) => new Complex() { Real =  (a.Real * b.Real), Img = (a.Img * b.Img) };
        public static Complex operator /(Complex a, Complex b) => new Complex()
        {
            Real = (b.Real == 0) ? a.Real : (a.Real / b.Real),
            Img = (b.Img == 0) ? a.Img : (a.Img / b.Img)
        };

        // Comparison Operation
        public static bool operator >(Complex a, Complex b) => (a.Real > b.Real) && (a.Img > b.Img);
        
        public static bool operator <(Complex a, Complex b) => (a.Real < b.Real) && (a.Img < b.Img);

        public static bool operator >=(Complex a, Complex b) => (a.Real >= b.Real) && (a.Img >= b.Img);

        public static bool operator <=(Complex a, Complex b) => (a.Real <= b.Real) && (a.Img <= b.Img);
        public static bool operator ==(Complex a, Complex b) => (a.Real == b.Real) && (a.Img == b.Img);
        public static bool operator !=(Complex a, Complex b) => (a.Real != b.Real) || (a.Img != b.Img);

        // Integer and Floation-point operations
        public static long operator +(long a, Complex c) => a + c.Real;
        public static double operator +(double a, Complex c) => a + c.Img;
        public static long operator -(long a, Complex c) => a - c.Real;
        public static double operator -(double a, Complex c) => a - c.Img;
        public static long operator *(long a, Complex c) => a * c.Real;
        public static double operator *(double a, Complex c) => a * c.Img;
        public static long operator /(long a, Complex c) => (c.Real == 0) ? 0 : a / c.Real;
        public static double operator /(double a, Complex c) => (c.Img == 0) ? 0 : a / c.Img;
        
        // Implicit and Explicit Overloading

        public static implicit operator int(Complex a) => a.Real;
        public static explicit operator Complex(int a) => new Complex { Real = a, Img = a};

        //Increment and decrement Overloading

        public static Complex operator ++(Complex c1) => new Complex { Real = c1.Real + 1, Img = c1.Img + 1 };
        public static Complex operator --(Complex c1) => new Complex { Real = c1.Real - 1, Img = c1.Img - 1 };
        public override string ToString()
        {
            return $"{Real} + {Img}j";
        }
    }
}
