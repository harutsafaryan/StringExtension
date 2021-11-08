using System;

namespace Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input any string: ");
            string str = Console.ReadLine();

            Console.WriteLine($"Space count is: {str._SpaceCount()}");
            Console.WriteLine($"String withot spaces: {str._RemoveSpaces()}");
            Console.WriteLine($"Max letter in the string is: {str._LetterWithMaxCount()}");
        }
    }
}
