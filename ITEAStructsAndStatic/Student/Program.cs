using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>();
            Student student1 = new Student("Иван","Иванов",new DateTime(2001,12,01),10.5f);
            list.Add(student1);
            Student student2 = new Student("Сергей","Сидоров",new DateTime(2000,04,10),10f);
            list.Add(student2);
            Student student3 = new Student("Светлана","Васильевна",new DateTime(1973,10,12),8f);
            list.Add(student3);
            Student student4 = new Student("Александр", "Фролов", new DateTime(1980, 01, 01), 12f);
            list.Add(student4);
            Student student5 = new Student("Богдан", "Филипенко", new DateTime(2000, 06, 15), 11.5f);
            list.Add(student5);
            Student student6 = new Student("Андрей", "Григорьев", new DateTime(2000, 06, 15), 7f);
            list.Add(student6);

            Console.WriteLine("Общее количество студентов: " + Counter.getCount());
            Console.WriteLine("Средний балл всех студентов: " + Counter.AllAverScore(list));
            Console.WriteLine("Список студентов:");
            Counter.getAllInfo(list);
            string testName1 = "Иван";
            Console.WriteLine("Список студентов с именем: " + testName1);
            Counter.getInfo(list, testName1);
            string testName2 = "Сергей";
            Console.WriteLine("Список студентов с именем: " + testName2);
            Counter.getInfo(list, testName2);
            string tesSecName1 = "Филипенко";
            Console.WriteLine("Список студентов с фамилией: " + tesSecName1);
            Counter.getInfo(tesSecName1, list);
            string tesSecName2 = "Григорьев";
            Console.WriteLine("Список студентов с фамилией: " + tesSecName2);
            Counter.getInfo(tesSecName2, list);
            Console.ReadKey();


        }
    }
}
