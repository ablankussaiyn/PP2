using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MinimumPrimeNumber
{
    class Program
    {
        public static bool IsPrime(int n)/*жай сандарды табу алгоритмі*/
        {
            if (n == 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            for (int i = 3; i * i <= n; i += 2)
            {
                if (n % i == 0) return false;
            }

            return true;
        }

        public static void Main(string[] args)
        {   
            StreamWriter sw = new StreamWriter(@"C:\Users\Аблан\Documents\PP2\Lab 2\MinimumPrimeNumber\Primes.txt");
            string line = File.ReadAllText(@"C:\Users\Аблан\Documents\PP2\Lab 2\MinimumPrimeNumber\Minprime.txt");
            string[] arr = line.Split(' ');
            //int min = 0;

            var list = new List<int>();

            foreach (string num in arr)
            {
                int a = Int32.Parse(num);
                if (IsPrime(a))
                {                    
                    list.Add(a);
                                               
                                                                    
                }
                

            }
            int mint = list.Min();
            sw.Write(mint);
            sw.Close();
           
        }


    }
}
