﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Complex
{
   class Complex
   {
      double re;
      double im;

      public Complex(double re, double im)
      {
         this.re = re;
         this.im = im;
      }

      public Complex(double re)
         : this(re, 0)
      {
      }

      public double Re
      {
         get { return re; }
         set { re = value; }
      }

      public double Im
      {
         get
         {
            return im;
         }
         set
         {
            im = value;
         }
      }

      public override string ToString()
      {
         return String.Format("{0:f2}+{1:f2}i", re, im);
      }

      //public override bool Equals(object obj)
      //{
      //   return this == (Complex)obj;
      //}

      //public override int GetHashCode()
      //{
      //   return ((int)re) ^ ((int)im);
      //}

      public static Complex operator +(Complex x, Complex y)
      {
         return new Complex(x.re + y.re, x.im + y.im);
      }

      public static Complex operator -(Complex x, Complex y)
      {
         return new Complex(x.re - y.re, x.im - y.im);
      }

      public static Complex operator *(Complex x, Complex y)
      {
         return new Complex(x.re * y.re - x.im * y.im, x.re * y.im + y.re * x.im);
      }

      public static Complex operator /(Complex x, Complex y)
      {
         double n = y.re * y.re + y.im * y.im;
         return new Complex((x.re * y.re + x.im * y.im) / n, (y.re * x.im - x.re * y.im) / n);
      }

      public static bool operator ==(Complex x, Complex y)
      {
         return x.re == y.re && x.im == y.im;
      }

      public static bool operator !=(Complex x, Complex y)
      {
         return x.re != y.re || x.im != y.im;
      }

      public static explicit operator double(Complex x)
      {
         return x.re;
      }

      public static implicit operator Complex(double x)
      {
         return new Complex(x, 0);
      }

   }
}