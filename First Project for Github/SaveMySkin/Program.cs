using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveMySkin
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 7; i++)
            {
                Console.Write("{0," + i + "}", "*");
                for (int j = 1; j <= 7 - i; j++)
                    Console.Write("*");

                {
                    Console.WriteLine();
                }

            }
        }
    }
}
