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

            while (phrase != null)
            {
                phrase = Console.ReadLine();
                strings.Enqueue(phrase);
            }
        }
    }
}
