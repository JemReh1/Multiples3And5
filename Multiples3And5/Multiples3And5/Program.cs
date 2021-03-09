using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples3And5
{
    class Program
    {
        static void Main(string[] args)
        {
            int number3 = 3;
            int number5 = 5;
            int multipleOf3 = 3;
            int multipleOf5 = 5;

            while (number3 < 1000)
            {
               
                //Console.WriteLine(multipleOf3);
                number3 += 3;
                multipleOf3 += number3;

            }
            while (number5 < 1000)
            {
           
                //Console.WriteLine(multipleOf5);
                number5 += 5;
                multipleOf5 += number5;

            }
            multipleOf3 -= number3;//subtracting extra multiple of 3
            multipleOf5 -= number5;//subtracting extra multiple of 5
            Console.WriteLine(multipleOf3 + multipleOf5);

           
        }
    }
}
