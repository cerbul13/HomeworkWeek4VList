using System;

namespace HomeworkWeek4VList
{
    class Program
    {
        static void Main(string[] args)
        {
            //students[0] = new Student();    //read from console for parameterless constructor
            Student st0 = new Student(33, "Cosmin");
            Student st1 = new Student(41, "Dan");
            st1.ReadMark();
            Student st2 = new Student(37, "Diana");
            st2.ReadMark();
            Student st3 = new Student(35, "Ionel");
            st3.ReadMark();
            Student st4 = new Student(45, "Iulia");
            Console.WriteLine("Valoarea medie a mark-ului, este {0}.", Student.GetAverageMark());
        }
    }
}