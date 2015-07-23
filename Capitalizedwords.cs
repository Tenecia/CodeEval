using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CodeEvalCapitalizedwords
{
    class Program
    {
        static void Main(string[] args)
        {
            string Newlinestore = "";
            string line = "all about the title case JavaScript";
            String[] arrayLine = line.Split();
            

            foreach (string s in arrayLine)
            {
                string result = char.ToUpper(s[0]) + s.Substring(1);
                Newlinestore = Newlinestore + " " + result;
            }
            System.Console.WriteLine(Newlinestore);

            //string titleCase = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(line);
           // Console.WriteLine(titleCase);
            Console.ReadLine();
        }
                
    }

       
}
