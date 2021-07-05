using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp_DigitCount
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Write("Your num ... : ");
                int n = int.Parse(ReadLine());

                int count = 0;

                do
                {
                    n = n / 10;
                    count++;
                } while (n > 0);

                WriteLine("Digit Count is " + count);
                WriteLine("Press any key to continue or Esc to quit ");
            } while (ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
