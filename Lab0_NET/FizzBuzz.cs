using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab0_NET
{
    internal class FizzBuzz
    {
        int uB;
        public FizzBuzz(int uB) { this.uB = uB; }
        public void Display()
        {
            for(int i = 1; i <= uB; i++)
            {
                string str = "";
                if (i % 3 == 0) str += "Fizz";
                if (i % 5 == 0) str += "Buzz";
                if (str == "") Console.WriteLine(i);
                else Console.WriteLine(str);
            }
        }
    } 
}
