using System;
using IO = System.Console;

namespace ConsoleApp1
{
    class Program
    {
        const int INCHES_PER_FOOT = 12;
        const double CM_TO_INCHES = 2.54;

        static void Main(string[] args)
        {
            // Part 1
            IO.Write("First Name     : ");
            string firstName = IO.ReadLine();
            IO.Write("Middle Initial : ");
            string middleInitial = IO.ReadLine();
            IO.Write("Last Name      : ");
            string lastName = IO.ReadLine();
            string fullName = firstName + " " + middleInitial + ". " + lastName;

            // Part 2
            IO.Write("Feet           : ");
            int feet = int.Parse(IO.ReadLine());
            IO.Write("Inches         : ");
            double extraInches = double.Parse(IO.ReadLine());
            int numInches = feet * INCHES_PER_FOOT;
            double totalInches = numInches + extraInches;
            double totalHeightCM = totalInches * CM_TO_INCHES;

            // Part 3
            IO.Write("Age            : ");
            int age = int.Parse(IO.ReadLine());
            IO.Write("Citizen?       : ");
            string isCitizenString = IO.ReadLine().ToLower();
            bool isCitizen = isCitizenString.Contains("y") || isCitizenString.Contains("t");
            bool canVote = isCitizen && age >= 18;

            // part 4
            IO.WriteLine("Name :" + fullName);
            IO.WriteLine("Citizen :" + isCitizen);
            IO.WriteLine("Age :" + age);
            IO.WriteLine("can vote :" + canVote);
            IO.WriteLine("Height in IN :" + totalInches);
            IO.WriteLine("Height in CM :" + totalHeightCM);
            IO.ReadKey();

        }
    }
}
