using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class Student : IPerson
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public DateTime BirthDate { get; set; }
        public float AverScore { get; set; }

        public Student(string firstName, string secondName, DateTime birthDate, float averScore)
        {
            FirstName = firstName;
            SecondName = secondName;
            BirthDate = birthDate;
            AverScore = averScore;
            Counter.AddStudent();
        }
    }
}
