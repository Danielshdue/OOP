using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Student test = new Student();
            test.Name = "Daniel Petrov";
            test.Adress = "Gabrovo";
            test.ID = "egene";
            test.Field = "KST";
            test.Number = 22405109;
            test.Semester = 2;
           // test.Info();
            Teacher proba = new Teacher();
            proba.Name = "Dido";
            proba.Adress = "Gabrovo";
            proba.ID = "egene";
            proba.Dlujnost = "profesor";
            proba.Disciplini = "matematika";
            Console.WriteLine(proba.Programa());

        }
    }
}
