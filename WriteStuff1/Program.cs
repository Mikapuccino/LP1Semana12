using System;
using System.IO;
using System.Collections.Generic;

namespace WriteStuff1
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> strings = new Queue<string>();
            string phrase = "start";

            while (phrase != "")
            {
                phrase = Console.ReadLine();
                strings.Enqueue(phrase);
            }

            File.WriteAllLines(args[0], strings);
        }
    }
}
