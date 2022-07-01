using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public abstract class Person
    {
        private int age;
        public  int Age{ get { return age; } set { age = value; } }

        private decimal salary;
        public decimal Salary { get { return salary; } set { salary = value; } }

        private string[] addresses;
        public string[] Addresss { get { return addresses; } set { addresses = value; } }


        public string[] getAddress()
        {
            return addresses;
        }

        // Display info
        //public void DisplayDimension()
        //{
        //    Console.WriteLine("The radius of tank is :" + Radius
        //             + " and the height of tank is :" + Height);
        //}

        public Person()
        {

        }

        public virtual decimal getSalary()
        {
            return 70000;
        }
    }
}
