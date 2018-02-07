using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Circle
    {
        const double pi = Math.PI;
        double radius;
        public void Area(double r)
        {
            this.radius = r;
            double A = pi * r * r;
            Console.WriteLine("the area = " + A);
        }
        public void Diameter(double r)
        {
            this.radius = r;
            Console.WriteLine("the diameter = " + 2 * r);
        }
        public void Circumference(double r)
        {
            this.radius = r;
            double C = 2 * pi * r;
            Console.WriteLine("the circumference = " + C);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle s = new Circle();
            int x = Int32.Parse(Console.ReadLine());
            s.Area(x);
            s.Circumference(x);
            s.Diameter(x);
            Console.ReadKey();

        }
    }
}
