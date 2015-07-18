using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ageDistribution
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 0;  //set to zero because we want user to enter a their age
            int i = 1;

            int GenX = 0;
            int GenY = 0;
            int Younger = 0;
            int Older = 0;
            int Silent = 0;

            for (i = 1; i <= 10; i++)
            {

                System.Console.WriteLine("How old are you?");
                age = Convert.ToInt32(Console.ReadLine());  //Convert.toInt32 MUST go after the question!!!!
                //store = store + age;
                if (age > 17 && age <= 32)
                {
                    System.Console.Write("You are a Generation Y!   ");
                    GenY += 1;
                }
                else if (age > 32 && age <= 44)
                {
                    System.Console.Write("You are a Generation X!   ");
                    GenX += 1;
                }
                else if (age > 44 && age <= 54)
                {
                    System.Console.Write("Younger Boomer!   ");
                    Younger += 1;
                }
                else if (age > 54 && age <= 63)
                {
                    System.Console.Write("Older Boomer!   ");
                    Older += 1;
                }
                else if (age > 63 && age <= 70)
                {
                    System.Console.Write("Silent Generation!     ");
                    Silent += 1;
                }
            }
            System.Console.WriteLine("There are " + GenY + " Generations in Gen Y");
            System.Console.WriteLine("There are " + GenX + " in Generation X");
            System.Console.WriteLine("There are " + Younger + " in Generation Younger");
            System.Console.WriteLine("There are " + Older + " Generations in Older Boomer");
            System.Console.WriteLine("There are " + Silent + " Generations in Silent Generation");
            System.Console.ReadLine();

            //work on age distributions for HW in code eval 7/18/2015




        }

    }


}