using System;
using System.Collections.Generic;
using System.Text;

namespace lazy
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;
            List<char> remove = new List<char>() { 'a', 'b', 'd', 'e', 'g', 'o', 'p', 'q' , ' '};
            bool isFirst = true;
            while((ch = (char)Console.Read()) != '.')
            {
                if (!remove.Contains(ch))
                {
                    Console.Write((char)(ch + (isFirst ? 'A' - 'a' : 0)));
                    isFirst = false;
                }
            }

            Console.WriteLine();
        }
    }
}
