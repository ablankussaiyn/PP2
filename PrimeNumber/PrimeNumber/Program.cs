using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{

    class Program
    {
        static void Main(string[] args)
        {
            int a;
            string  s = Console.ReadLine();/*сандарды консольға енгізу*/
            string[] array = s.Split(' ');/*строканы массивке айналдыру*/
            foreach (var num in array)
            {
                Int32.TryParse(num, out a);/*массивтегі сандарды колдануга мумкиндик алу*/

                if (IsPrime(a))
                {
                    Console.WriteLine(a);/*жауапты консольга шыгару*/
                }
                else {
                    continue; }


            }
            Console.ReadKey();/*программаны жабу*/
        }


        static bool IsPrime(int n)/*жай сандарды табу алгоритмі*/
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

    }
}



         