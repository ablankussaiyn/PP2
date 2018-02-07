using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Student
    {
        string name;
        string surname;

        public void Readinfo()
        {
            name=Console.ReadLine();
            surname=Console.ReadLine();
        }

      
        public void Printinfo()
        {
            Console.WriteLine(name + " " + surname);

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student line = new Student();
            line.Readinfo();
            line.Printinfo();
            Console.ReadKey;
        }
    }
}
