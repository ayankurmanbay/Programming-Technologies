﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classComplex
{
    class Complex
    {
        public int a, b;
        public Complex(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public static Complex operator +(Complex x, Complex y)
        {
            Complex z = new Complex(x.a + y.b, x.b + y.a);
            return z;
        }
        public override string ToString()
        {
            return a + " " + b; 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int a1 = int.Parse(Console.ReadLine());
            int b1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());
            int b2 = int.Parse(Console.ReadLine());
            Complex sum1 = new Complex(a1, b1);
            Complex sum2 = new Complex(a2, b2);
            Complex sumfin = sum1 + sum2;
            Console.WriteLine(sumfin);
            Console.ReadKey();
        }
    }
}
