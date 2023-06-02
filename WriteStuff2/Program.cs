using System;
using System.IO;
using System.Collections.Generic;

namespace WriteStuff1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter(args[0]);
            
            string phrase = "start";

            while (phrase != "")
            {
                phrase = Console.ReadLine();
                sw.WriteLine(phrase);
            }

            sw.Close();
        }
    }
}
