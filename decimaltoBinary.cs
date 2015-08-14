using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeEvaldecimalTobinary
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a Number");
            int DecimalVal = int.Parse(Console.ReadLine());
            string BinaryVal = Convert.ToString(DecimalVal, 2); //method
            Console.WriteLine(BinaryVal);
            Console.ReadLine();



        }
    }
}
