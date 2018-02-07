using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student1
{
    class Student
    {
        string name;
        string surname;

        public void Readinfo()
        {
            name = Console.ReadLine();
            surname = Console.ReadLine();
        }

        public void Showinfo()
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
            line.Showinfo();
            Console.ReadKey();

        }
    }
}
