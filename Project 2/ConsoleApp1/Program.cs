using System;
using IO = System.Console;
namespace ConsoleApp5
{
    class Program
    {

        static void Main(string[] args)
        {
            PersonAT1 person1 = new PersonAT1();
            person1.userinput();
            person1.maritalstatus();

            PersonAT1 person2 = new PersonAT1();
            person2.userinput();
            person2.maritalstatus();

            person1.PrintNameAndAge();
            if (person1.spouse != null) { person1.spouse.PrintNameAndAge(); }
            person2.PrintNameAndAge();
            if (person2.spouse != null) { person2.spouse.PrintNameAndAge(); }

            IO.WriteLine("");

            IO.WriteLine("Average Age: " + PersonAT1.AverageAge());
            IO.WriteLine("prese any key to exit or press the (x) button in the top right corner");
            IO.ReadKey();
        }
    }
}