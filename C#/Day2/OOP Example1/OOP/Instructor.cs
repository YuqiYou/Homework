using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Instructor: Person
    {
        //DateTime joinTime = new DateTime(1999, 1, 28);

        private bool isHead;
        public bool IsHead { get { return isHead; } set { isHead = value; } }

        private int joinYear;
        public int JoinYear { get { return joinYear; } set { joinYear = value; } }

        


        public Instructor(String department, bool isHead, DateTime joinDate, int age, string[]address)
        {
            IsHead = isHead;
            JoinYear = joinDate.Year;
            Age = age;
            Addresss = address;
         
        }

        public override decimal getSalary()
        {
            Salary = 70000 + (DateTime.Now.Year - JoinYear) * 15000;
            return Salary;
        }

        
    }
}
