using System;
using IO = System.Console;
namespace ConsoleApp5
{
    class tool
    {
        public static string Qspouse()
        {
            string spouse = "y";
            bool keepAsking = true;
            while (keepAsking)
            {
                IO.Write("Are you married y/n : ");
                spouse = IO.ReadLine().ToLower();
                if (spouse == "y" || spouse == "n")
                {
                    keepAsking = false;
                }
            }
            return spouse;
        }
    }
}