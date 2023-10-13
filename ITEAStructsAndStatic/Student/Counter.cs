using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Student
{
    public static class Counter
    {
        static int counter = 0;
        public static void AddStudent()
        {
            counter++;
        }
        public static int getCount()
        {
            return counter;
        }
        public static double AllAverScore(List<Student> students)
        {
            double sum = 0;
            foreach (Student student in students)
            {
                sum += student.AverScore;
            }
            return sum/students.Count();
        }
        public static void getAllInfo(List<Student> students)
        {
            foreach(Student student in students)
            {
                Console.WriteLine($"Имя: {student.FirstName} Фамилия: {student.SecondName} Дата рождения: {student.BirthDate.ToShortDateString()}");
                Console.WriteLine("======================");
            }
        }
         static List<Student> GetStudent(List<Student> list,string Name) 
        {
            List<Student> result = new List<Student>();
            foreach(var student in list)
            {
                if (student.FirstName.Equals(Name))
                {
                    result.Add(student);
                }
            }
            return result;
        }
         static List<Student> GetStudent(string SecName, List<Student> list)
        {
            List<Student> result=new List<Student>(); 
            foreach (var student in list)
            {
                if (student.SecondName.Equals(SecName))
                {
                    result.Add(student);
                }
            }
            return result;
        }
        public static void getInfo(List<Student> students,string FirstName)
        {
            List<Student> res=GetStudent(students,FirstName);
            if(res.Count>0)
            {
                getAllInfo(res);
                Console.WriteLine("Поиск завершен");

            }
            else
            {
                Console.WriteLine("Никто не найден!");
            }
        }
        public static void getInfo(string SecName,List<Student> students)
        {
            List<Student> res=GetStudent(SecName,students);
            if(res.Count>0)
            {
                getAllInfo(res);
                Console.WriteLine("Поиск завершен");
            }
            else
            {
                Console.WriteLine("Никто не найден!");
            }
        }
    }
}
