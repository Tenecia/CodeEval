using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeEvalEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
                        
            for (i = 0; i <= 5000; i++)
            {
                if (i % 2 == 0)
                {
                    System.Console.WriteLine("0");
                }

                if (i % 2 != 0)
                {
                    System.Console.WriteLine("1");
                }

            }
            Console.ReadLine();
        }
        

    }
}