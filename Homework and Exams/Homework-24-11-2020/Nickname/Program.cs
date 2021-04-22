using System;

namespace Nickname
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = -1;
            while(true)
            {
                char ch = (char)Console.Read();
                if (ch == '.')
                {
                    Console.WriteLine('.');
                    break;
                }
                counter++;
                if(counter % 2 == 0)
                {
                    if(ch >= 'a' && ch <= 'z')
                    {
                        ch = (char)(ch + ('A' - 'a'));

                    }
                }
                else
                {
                    if (ch >= 'A' && ch <= 'Z')
                    {
                        ch = (char)(ch + ('a' - 'A'));

                    }
                }

                Console.Write(ch);
            }
        }
    }
}
