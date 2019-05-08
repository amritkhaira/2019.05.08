using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
// first program to add numnbers by stepping down

            int sum = 0;
            int start = 314;
            int end = 102;
            for (int i = start; i <= end; i--)
            {
                Console.WriteLine(end + "" + i);

                sum += i;
            }
            Console.ReadLine();

        }
    }
}