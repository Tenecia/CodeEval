using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeEvalReverseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = File.OpenText(args[0]))
                while (!reader.EndOfStream)
                {
                    string Line = reader.ReadLine();
                    if (null == line)
                        continue;
                    string store = "";

                    String[] arrayLine = Line.Split();
                    Array.Reverse(arrayLine);

                    foreach (string result in arrayLine)
                    {
                        store = store + " " + result;
                    }
                    string newstore = store.Trim();
                    Console.WriteLine(newstore);
                }

        }
    }
}