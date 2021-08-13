using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareFigures
{
    public static class Squares
    {
        public static double GetSquare(double A, double B, double C)
        {
            double s;
            double p;
            p = (A + B + C) / 2;
            s = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return s;
        }
        public static double GetSquare(double R)
        {
            double s;
            s = 2*Math.PI*R*R;
            return s;
        }
    }
}
