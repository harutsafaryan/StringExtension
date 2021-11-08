using System;

namespace Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello world";
            int s = str._SpaceCount();

            bool b = str._IsContainWord("world");
            char c = str._LetterWithMaxCount();
            string sss = str._RemoveSpaces();
            Console.WriteLine(sss); 
        }
    }
}
