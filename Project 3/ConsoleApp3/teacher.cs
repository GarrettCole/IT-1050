using System;
using IO = System.Console;
namespace ConsoleApp3
{
    class teacher
    {
        private string name;
        private string coursename;

        public teacher(string name, string coursename)
        {
            this.name = name;
            this.coursename = coursename;
        }

        public void setclassgrade(student s1, int grade)
        {
            s1.SetGrade(grade);
        }
        
        public void printTeacher()
        {
            IO.WriteLine(this.name + toolkit.Space(this.name) + this.coursename);
        }
    }

}
