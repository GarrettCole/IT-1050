using System;
using IO = System.Console;
namespace ConsoleApp3
{
    class toolkit
    {
        public static void PrintHeader()
        {
            IO.WriteLine("     Student Name       Grade           Teacher Name       Course Name");
        }

        public static string Space(string chain)
        {
            string spaces = "";
            int chainSpaces = chain.Length;
            int numSpaces = 18 - chainSpaces;
            for (int i = 0; i < numSpaces; i++)
            {
                spaces = spaces + " ";
            }
            return (spaces);
        }
    }
}
