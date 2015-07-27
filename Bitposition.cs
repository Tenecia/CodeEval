using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeEvalBitPosition
{
    class Program
    {
        static void Main(string[] args)
        {

           
            string line = "86,2,3";
            string[] removeNumber = line.Split(','); // will spilt at the comma
            int store86 = Int32.Parse(removeNumber[0]); // remove 86 from string and make it an integer
            int storeP1 = Int32.Parse(removeNumber[1]); // remove 2 (position1) from string and make it an integer
            int storeP2 = Int32.Parse(removeNumber[2]);// remove 3 (position 2) from string and make it an integer
            //string binary = Convert.ToString(store86, 2); // takes 86 & calculates it binary 
            if (((store86>>(storeP1-1))&1) == ((store86>>storeP2-1)&1))   // single ampersand (&) means bit comparison 
            {
                System.Console.WriteLine("true");

            }
            else { 
                System.Console.WriteLine("false"); }

            
            System.Console.ReadLine();   
            

        }
    }
}
