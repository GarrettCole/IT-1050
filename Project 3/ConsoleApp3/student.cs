using System;
using IO = System.Console;
namespace ConsoleApp3
{
    class student
    {
        private string name;
        private teacher GetTeacher;
        private int grade;

        public student(string name, teacher GetTeacher, int grade)
        {
            this.name = name;
            this.GetTeacher = GetTeacher;
            this.grade = grade;
        }

        public void SetGrade(int grade)
        {
            this.grade = grade;
        }
        
        public void print()
        {
            IO.Write("       " + this.name + toolkit.Space(this.name) + this.grade + toolkit.Space(this.grade.ToString()));
            GetTeacher.printTeacher();
        }
    }
}
