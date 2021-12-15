﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkWeek4VList
{
    class Student
    {
        private int age;
        private string name;
        public const int MIN_AGE = 18;
        public const int MAX_AGE = 99;
        private static List<Student> studentsList;
        public int Age
        {
            get { return age; }
            set
            {
                if (value < MIN_AGE || value > MAX_AGE)
                {
                    throw new Exception("Varsta studentului " + name + " nu se incadreaza in limitele impuse de MIN_AGE si MAX_AGE.");
                }
                else
                {
                    age = value;
                }
            }
        }
        public int? Mark { get; set; }
        public string Info
        {
            get { return "Nume: " + name + " , Varsta: " + age; }
        }
        static Student()
        {
            studentsList = new List<Student>();
        }
        public Student(int newage, string newname)
        {
            name = newname;
            Age = newage;
            Console.WriteLine("Student adaugat cu succes. " + Info);
            studentsList.Add(this);
        }
        public Student()
        {
            Console.Write("Introduceti numele studentului: ");
            name = Console.ReadLine();
            Console.Write("Introduceti varsta studentului {0}: ", name);
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Student adaugat cu succes. " + Info);
            studentsList.Add(this);
        }
        public void ReadMark()
        {
            Console.Write("Introduceti mark pentru studentul {0}: ", name);
            string mark = Console.ReadLine();
            Mark = int.Parse(mark);
        }
        public static decimal GetAverageMark()
        {
            int suma = 0;
            int nrStudentiCuMark = 0;
            foreach(Student student in studentsList)
            {
                if (student.Mark.HasValue) { suma += (int)student.Mark;nrStudentiCuMark++; }
            }
            return (decimal)suma / nrStudentiCuMark;
        }
    }
}
