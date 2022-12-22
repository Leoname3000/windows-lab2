using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsLab2
{
    interface IFunction
    {
        double calc(double x);
    }

    public class Sin : IFunction
    {
        public double calc(double x)
        {
            return Math.Sin(x);
        }
    }

    public class Square : IFunction
    {
        public double calc(double x)
        {
            return x * x;
        }
    }

    public class Tg : IFunction
    {
        public double calc(double x)
        {
            return Math.Tan(x);
        }
    }

    public class Cube : IFunction
    {
        public double calc(double x)
        {
            return x * x * x;
        }
    }

    public class Linear : IFunction
    {
        public double calc(double x)
        {
            return 2 * x + 5;
        }
    }
}
