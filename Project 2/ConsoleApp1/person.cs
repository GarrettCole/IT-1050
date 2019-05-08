using System;
using IO = System.Console;
namespace ConsoleApp5
{
    class PersonAT1
    {
        public int age;
        public string firstName;
        public string middleInitial;
        public string lastName;
        public PersonAT1 spouse;
        public static int count;
        public static int totalage;

        public static double AverageAge()
        {
            return (double)totalage / (double)count;
        }

        public void userinput()
        {
            IO.Write("First Name                                        : ");
            this.firstName = IO.ReadLine();
            IO.Write("Middle Initial                                    : ");
            this.middleInitial = IO.ReadLine();
            IO.Write("Last Name                                         : ");
            this.lastName = IO.ReadLine();
            IO.Write("age                                               : ");
            age = int.Parse(IO.ReadLine());
            count++;
            totalage += this.age;
        }

        public string GetFullName()
        {
            return this.firstName + "," + this.middleInitial + " " + this.lastName;
        }

        public void PrintNameAndAge()
        {
            IO.WriteLine(this.GetFullName());
            IO.WriteLine(this.age);
        }

        public void maritalstatus()
        {

            if (tool.Qspouse() == "y")
            {
                this.spouse = new PersonAT1();
                IO.Write("Enter your Spouse's first name                  : ");
                spouse.firstName = IO.ReadLine();
                IO.Write("Enter your Spouse's Middle Initial              : ");
                spouse.middleInitial = IO.ReadLine();
                spouse.lastName = this.lastName;
                IO.Write("Enter Your Spouse's Age                         : ");
                spouse.age = int.Parse(IO.ReadLine());
                count++;
                totalage += spouse.age;

                this.spouse.spouse = this;
            }

        }
    }
}
