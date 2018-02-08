using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
    class Complex
    {
        public int a, b;

        public Complex(int x, int y)
        {
            a = x;
            b = y;

        }



        public Complex Add(Complex complex2)
        {
            Complex result = new Complex(this.a * complex2.b + complex2.a * this.b, this.b * complex2.b);

            return result;
        }
        public Complex Minus(Complex complex2)
        {
            Complex result = new Complex(this.a * complex2.b - complex2.a * this.b, this.b * complex2.b);

            return result;
        }
        public Complex Multiple(Complex complex2)
        {
            Complex result = new Complex(this.a * complex2.a, this.b * complex2.b);

            return result;
        }
        public Complex Division(Complex complex2)
        {
            Complex result = new Complex(this.a * complex2.b, this.b * complex2.a);

            return result;
        }


        public void Simplify()
        {
            int _a = this.a;
            int _b = this.b;
            while (_a > 0 && _b > 0)
            {
                if (_a > _b)
                    _a = _a % _b;
                else
                    _b = _b % _a;
            }
            int nod = _a + _b;
            a /= nod;
            b /= nod;
        }
        
    }
    class Program
    {        
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] arr = s.Split();
            Complex result = new Complex(0, 0);
            foreach (string t in arr)
            {
                string[] a = t.Split('/');
                Complex cmp = new Complex(int.Parse(arr[0]), int.Parse(arr[1]));
                result =result+ cmp;
            }
            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}
