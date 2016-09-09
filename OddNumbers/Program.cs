using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter;
            for (counter = 1; counter <= 99; counter += 2)
            {
                System.Console.WriteLine(counter);
            } 
        }
    }
}
