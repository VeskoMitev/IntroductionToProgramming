using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime yearOfBirth = DateTime.Parse( Console.ReadLine());
            Console.WriteLine("Now: {0:d}\nAfter 10 years: {1:d}", DateTime.Now.Year - yearOfBirth.Year, (DateTime.Now.Year - yearOfBirth.Year)+10);
        }
    }
}
