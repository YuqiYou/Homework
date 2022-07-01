using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class student:Person
    {
        private string courseTake;
        public string CourseTake { get { return courseTake; } set { courseTake = value; } }

        private int grade;
        public int Grade { get { return grade; } set { grade = value; } }


        public student(string courseTake, int  grade, int age, string[] address)
        {
            CourseTake = courseTake;
            Grade = grade;

        }


        public double getGrade()
        {
            return Math.Floor(Grade / 25.0);
        }
    }
}
