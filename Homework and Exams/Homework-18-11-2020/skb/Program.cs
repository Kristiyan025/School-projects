using System;

namespace skb
{
    class Program
    {
        static void Main(string[] args)
        {
            int openSmall = 0,
                openMiddle = 0,
                openBig = 0,
                closeSmall = 0,
                closeMiddle = 0,
                closeBig = 0;
            int n = int.Parse(Console.ReadLine());
            char ch;
            for (int i = 0; i < n; i++)
            {
                ch = (char)Console.Read();
                switch (ch)
                {
                    case '(':
                        openSmall++;
                        break;
                    case '[':
                        openMiddle++;
                        break;
                    case '{':
                        openBig++;
                        break;
                    case ')':
                        closeSmall++;
                        break;
                    case ']':
                        closeMiddle++;
                        break;
                    case '}':
                        closeBig++;
                        break;
                }
            }

            Console.WriteLine(openBig == closeBig ? "0" : $"{(openBig > closeBig ? 'L' : 'R')}{Math.Abs(openBig - closeBig)}");
            Console.WriteLine(openMiddle == closeMiddle ? "0" : $"{(openMiddle > closeMiddle ? 'L' : 'R')}{Math.Abs(openMiddle - closeMiddle)}");
            Console.WriteLine(openSmall == closeSmall ? "0" : $"{(openSmall > closeSmall ? 'L' : 'R')}{Math.Abs(openSmall - closeSmall)}");
        }
    }
}