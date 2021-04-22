using System;

namespace Gift
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter1 = (char)Console.Read();
            char letter2 = (char)Console.Read();
            char letter3 = (char)Console.Read();
            char digit1 = (char)Console.Read();
            char digit2 = (char)Console.Read();
            char digit3 = (char)Console.Read();

            //sort letters
            if(letter1 > letter2)
            {
                char x = letter1;
                letter1 = letter2;
                letter2 = x;
            }
            if (letter1 > letter3)
            {
                char x = letter1;
                letter1 = letter3;
                letter3 = x;
            }
            if (letter2 > letter3)
            {
                char x = letter2;
                letter2 = letter3;
                letter3 = x;
            }

            //sort digits
            if(digit1 < digit2)
            {
                char x = digit1;
                digit1 = digit2;
                digit2 = x;
            }
            if (digit1 < digit3)
            {
                char x = digit1;
                digit1 = digit3;
                digit3 = x;
            }
            if (digit2 < digit3)
            {
                char x = digit2;
                digit2 = digit3;
                digit3 = x;
            }

            Console.WriteLine(letter1.ToString() + digit1 +
                              letter2 + digit2 +
                              letter3 + digit3);
        }
    }
}
