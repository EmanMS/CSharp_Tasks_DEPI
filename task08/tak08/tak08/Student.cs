﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tak08
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Grade { get; set; }

        public Student(int id, string name, double grade)
        {
            Id = id;
            Name = name;
            Grade = grade;
        }

        public Student(Student std) {
            Id = std.Id;
            Name = std.Name;
            Grade = std.Grade;
        }

        public override string ToString()
        {
            return $"Info: (id: {Id}, name: {Name}, grade: {Grade})";
        }


    }
}
