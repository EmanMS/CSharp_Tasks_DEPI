using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task09
{
    internal class Employee
    {
        //attributes 
        private int EmpID;
        private string EmpName;
        private decimal empsalary;

        //apply Encapsulatoin
        // geter name 
        public string GetName()
        {
            return EmpName;
        }
        // seeter >>> Get only , validation
        public void SetName(string value)
        {
            EmpName = value.Length <= 20 ? value : value.Substring(0, 20);
        }


        //apply Encapsulatoin //Property : full
        public decimal Salary
        {
            get { return empsalary; }
            set { empsalary = value < 4000 ? 4000 : value; }
        }
        // more readable : Automatic property : attribute implicite
        //Compiler generate backing field >> hidden private attr
        // private int age;
        // IL >> backing field >> self
        public int Age { get; set; } // can't access attributes : validation
        // prop without validation >> Auto >> readable

        //private int age;

        //public int Age
        //{
        //    get { return age; }
        //    set { age = value; }
        //}



        //Constructor
        public Employee(int _id, string _Name, decimal _salary, int _Age)
        {
            EmpID = _id;
            EmpName = _Name;
            empsalary = _salary;
            Age = _Age;
        }

        //Method
        public override string ToString()
        {
            return $"Emp Id is {EmpID}, Name is {EmpName}, Salary is {empsalary}, Age is {Age}";
        }

        // private int bonus;

        //readonly Prop >>> Access bonus >> Column in Database
        public decimal Bonus
        {
            get { return empsalary * 0.1M; }
        }


        public override bool Equals(object obj)
        {
            if (obj is Employee)
            {
                Employee other = (Employee)obj;
                return EmpID == other.EmpID && EmpName == other.EmpName && empsalary == other.empsalary && Age == other.Age;
            }
            return false;
        }
    }
}

