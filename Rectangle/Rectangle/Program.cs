using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Rectangle
    {
        double weidth;
        double height;
        public void Perimeter(double a, double b)
        {
            this.weidth = a;
            this.height = b;
            double P = 2 * (a + b);
            Console.WriteLine("the perimetr = " + P);
        }
        public void Area(double a_1,double b_1)
        {
            this.weidth = a_1;
            this.height = b_1;
            double A = a_1 * b_1;
            Console.WriteLine("the area = " + A );
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle s = new Rectangle();
            int x = Int32.Parse(Console.ReadLine());
            int y = Int32.Parse(Console.ReadLine());
            s.Area(x, y);
            s.Perimeter(x, y);
            Console.ReadKey();

        }
    }
}
