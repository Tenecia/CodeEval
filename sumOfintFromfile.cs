using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumOfpositiveIntegers_Tenecia
{
    class Program
    {
        static void Main(string[] args)
        {
            //set an array of positive integers
            //initialize sum variable to 0
            //run a loop to add each number in the array

            //5 elements in  array
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            //pass array to method
            //Console.WriteLine(Method(array));
            int solution = 0;

            for (int i = 0; i < array.Length; i++)
                //for(counter=0;solution<array.Length;solution++)
            {
                solution = solution + array[i];

            }

            System.Console.WriteLine(solution);
            //System.Console.WriteLine(array[0]);
            System.Console.ReadLine(); 
            //System.Console.WriteLine.array[solution];

        }
    }
}
