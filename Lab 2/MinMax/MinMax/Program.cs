using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            int min = 0;
            string s = File.ReadAllText(@"C:\Users\Аблан\Documents\PP2\Lab 2\MinMax\minmax.txt");
            string[] arr = s.Split(' ');
            foreach (var num in arr) 
            {
                Int32.TryParse(num, out int a);

                    if (max<a)
                    {
                        max = a;
                    }
                    if (min>a)
                    {
                        min = a;
                    }
                
            }
            Console.WriteLine("the maximum value = " + max);
            Console.WriteLine("the minimum value = " + min);
            Console.ReadKey();

        }
    }
}
