using System;
using System.Collections.Generic;
using System.IO;

namespace Lab6
{
    class Program
    {
        static void Main()
        {
            var path = @"c:\users\ilshat\test.txt";
            if (!File.Exists(path))
            {
                Console.WriteLine("Файла с заданным именем не существует.");
                Console.ReadKey();
                return;
            }

            using (var sr = File.OpenText(path))
            {
                string s;
                var stack = new Stack<string>();
                while ((s = sr.ReadLine()) != null)
                    stack.Push(s);
                foreach (var str in stack)
                {
                    Console.WriteLine(str);
                }
            }
            Console.ReadKey();
        }
    }
}
