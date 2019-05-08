using ConsoleApp3;
using System;
using IO = System.Console;
namespace IT1050program3
{
    class Program
    {
        static void Main(string[] args)
        {
            teacher John = new teacher("John", "English");
            teacher Mike = new teacher("Mike", "Math");

            student Jane = new student("Jane", John, 0);
            student Joe = new student("Joe", John, 0);
            student Melissa = new student("Melissa", Mike, 0);
            student Matt = new student("Matt", Mike, 0);

            John.setclassgrade(Jane, 95);
            John.setclassgrade(Joe, 85);
            Mike.setclassgrade(Melissa, 90);
            Mike.setclassgrade(Matt, 92);

            toolkit.PrintHeader();

            Jane.print();
            Joe.print();
            Melissa.print();
            Matt.print();

            IO.WriteLine();
            IO.WriteLine("press any key to coninue");
            IO.ReadKey();
        }
    }
}
