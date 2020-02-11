using System;

namespace Complex
{
    class ComplexClass
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        public ComplexClass(double r, double i)
        {
            Real = r;
            Imaginary = i;
        }

        public ComplexClass() : this(0, 0) {}

        public ComplexClass(double r) : this(r, 0) { }

        public static ComplexClass operator +(ComplexClass r, ComplexClass i)
        {
            return new ComplexClass(r.Real + i.Real, i.Imaginary + i.Imaginary);
        }

        public static ComplexClass operator -(ComplexClass r, ComplexClass i)
        {
            return new ComplexClass(r.Real - i.Real, i.Imaginary - i.Imaginary);
        }

        public static ComplexClass operator *(ComplexClass r, ComplexClass i)
        {
            return new ComplexClass(r.Real * i.Real - r.Imaginary * i.Imaginary, r.Real * i.Imaginary + i.Real * r.Imaginary);
        }

        public static ComplexClass operator /(ComplexClass x, ComplexClass y)
        {
            double n = y.Real * y.Real + y.Imaginary * y.Imaginary;
            return new ComplexClass((x.Real * y.Real + x.Imaginary * y.Imaginary) / n, (y.Real * x.Imaginary - x.Real * y.Imaginary) / n);
        }

        public static bool operator !=(ComplexClass r, ComplexClass i)
        {
            return !(r == i);
        }

        public static bool operator ==(ComplexClass r, ComplexClass i)
        {
            return r.Real == i.Real ? i.Imaginary == i.Imaginary : false;
        }

        public override bool Equals(object obj)
        {
            ComplexClass num = (ComplexClass) obj;
            return base.Equals(obj) && this.Real == num.Real && this.Imaginary == num.Imaginary;
        }

        public override int GetHashCode()
        {
            int hash = 13;
            hash = (hash * 7) + Real.GetHashCode();
            hash = (hash * 7) + Imaginary.GetHashCode();
            return hash;
        }

        public static implicit operator string(ComplexClass num)
        {
            return num.ToString();
        }

        public static explicit operator double(ComplexClass x)
        {
            return x.Real;
        }

        public static implicit operator ComplexClass(double x)
        {
            return new ComplexClass(x, 0);
        }

        public override string ToString() {
            return this.Real + ", " + this.Imaginary;
        }

        static void Main(string[] args)
        {
            ComplexClass n1 = new ComplexClass(4, 4);
            ComplexClass n2 = new ComplexClass(4.0, 4);

            string num = n1;
            Console.WriteLine(num);
            Console.WriteLine(n1 == n2);
        }
    }
}
