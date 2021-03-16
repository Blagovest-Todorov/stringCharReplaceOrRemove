using System;
using System.Collections.Generic;
using System.Linq;

namespace ReplaceStringChars
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> listChar = Console.ReadLine()
                   .ToCharArray()
                   .ToList();

            for (int i = 0; i < listChar.Count - 1 ; i++)
            {
                char currChar = listChar[i];

                if (currChar == listChar[i + 1])
                {
                    listChar.RemoveAt(i);
                    i--;
                }
            }

            Console.WriteLine(string.Concat(listChar));
        }
    }
}
