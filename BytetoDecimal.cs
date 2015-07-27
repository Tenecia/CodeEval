using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BytetoDecimal
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console writeline app that asks the user for a byte, converts the byte to a decimal, and prints it. 
            System.Console.WriteLine("Please give me an 8 byte number");
            int sum = 0; //0 as a place holder
            string userAn = Console.ReadLine(); //This "variable set" up allows for user INPUT
            int Pow;
            int userNum;
            int counter;
            int arrayCount = 0;                                
                           

             for (counter=userAn.Length-1;counter >= 0; counter--)  // counter -- progresses the exponent starting at 7
                
            {
                 userNum = int.Parse(userAn[arrayCount].ToString()); //  int.Parse converts string to int. user an, its position in array. 
                 Pow = (int) Math.Pow(2, counter);  // ( use pow calculator : Math.Pow) binary raised to the counter 
                 sum += userNum*Pow;    // this multiplication step, userNumber x Pow result 
                 arrayCount++;     // progressing the arrary to the next space in the array , starting at 0
   
            }
            Console.WriteLine(sum);
            Console.ReadLine();

            


        }
    }
}
