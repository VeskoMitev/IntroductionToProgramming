using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToProgramming
{
    class PrintLongSequence
    {
        static void Main(string[] args)
        {
            int startSequence = 2;
            int lenSequence = 1000;
            for (int i = startSequence; i < startSequence + lenSequence; i++)
            {

                if (i % 2 == 0)
                {
                    Console.Write(i);
                }
                else
                {
                    Console.Write(i * -1);
                }

                // print separator
                if (i != startSequence + lenSequence - 1)
                {
                    Console.Write(",");
                }
            }
            //print new line
            Console.WriteLine();
        }
    }
}
