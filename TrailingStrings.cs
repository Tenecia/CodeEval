using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeEvalTrailingStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "Hello other World,World";
            string[] words;
            String[] line1 = line.Split(','); // "" means your "quoting" not identifying, splitting the fist Two Words 
           // while (line!=null)
            //{
                words = line.Split(',');
                string a = words[0];
                string b = words[1];
                if (a.EndsWith(b))
                {
                    Console.WriteLine("1");
                }
                else
                {
                    Console.WriteLine("0");
                    
                }
                Console.ReadLine();
            //}
           

            // //String[] a = line1[0].Split(); // split all the words 

            // //String b = line1[1]; //third word
            //// String a1 = a[1]; //the second word 

            // if (a1.CompareTo(b) == 0)
            // // if (a1 == b)
            // {
            //     Console.WriteLine("1");
            // }
            // else
            //     Console.WriteLine("0");

        }
        
    }
}
