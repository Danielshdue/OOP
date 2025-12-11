using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Student : Person
    {
        private int number, semester;
        private string field;
        public Student()
        {
            number = 0;
            semester = 0;
            field = null;
        }
        public string Field
        {
            get { return field; }
            set { field = value; }
        }
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        public int Semester
        {
            get { return semester; }
            set { semester = value; }
        }
        public void Info()
        {
            Console.WriteLine($"Name: {Name}\nId: {ID}\nAdress: {Adress}\nField: {Field}\nNumber: {Number}\nSemester: {Semester}");
        }
    }
}
