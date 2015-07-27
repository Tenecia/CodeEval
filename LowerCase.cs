using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lowerCase
{
    class Program
    {
        static void Main(string[] args)
        {
           string line = "are we lower yet";
           string lower = line.ToLower();
           Console.WriteLine(lower);
           Console.ReadLine();


        }
    }
}
