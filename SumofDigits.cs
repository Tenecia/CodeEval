using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeEvalSumofDigits
{
    class Program
    {
        static void Main(string[] args)
        {
                       
            string i = "12345";
            int s = i.Sum(c => Convert.ToInt32(c - '0'));
            Console.WriteLine(s);
            Console.ReadLine();          


        }
    }
}
