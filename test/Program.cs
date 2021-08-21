using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace test
{
    class Program
    {
        static void Calculate(ref int numValueOne,ref int numValueTwo)
        {
            var temp = numValueOne;
            numValueOne = numValueTwo;
            numValueTwo = temp;
        }
        static void Main(string[] args)
        {
            int numOne = 10;
            int numTwo = 20;
            Console.WriteLine("Value of Num1 and Num2 before calling method " + numOne + ',' + numTwo);
            Calculate(ref numOne,ref numTwo);
            Console.WriteLine("Value of Num1 and Num2 after calling method " + numOne + ',' + numTwo);
        }
    }
}
