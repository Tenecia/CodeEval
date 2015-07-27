using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fizzBuzz_Tenecia
{
    class Program
    {
        static void Main(string[] args)
        {
            int fizzX;
            int buzzY;
            int countTo;
            int increment;



            fizzX = 3;
            buzzY = 2;
            countTo = 20;
            increment = 1;

            System.Console.WriteLine();


            //loop through each increment
            //decide if the increment value is divisible by x, y, or both
            //print the value, f, b, or fb to the console. 

            using (StreamReader reader = File.OpenText(args[0]))
            {
                while (!reader.EndOfStream)
                {
                    int[] array = reader.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray<int>(); List<string> list = new List<string>();


                    for (increment = 1; increment <= countTo; increment++)
                    {
                        if (increment % array[0] == 0 && increment % array[1] == 0) { System.Console.Write("FB "); }
                        else if (increment % array[0] == 0) { System.Console.Write("F "); }
                        else if (increment % array[1] == 0) { System.Console.Write("B "); }

                        else
                        {
                            System.Console.Write(increment.ToString() + " ");

                        }

                    }
                    Console.WriteLine(string.Join("", list.ToArray<string>()));
                }
                //System.Console.ReadLine();
            }

        }
    }
}






























