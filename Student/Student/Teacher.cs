using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Teacher : Person
    {   
        private string dlujnost;
        private string[] disciplini = new string[];
        public Teacher()
        {
            dlujnost = null;
            disciplini = null;
        }
        public string Dlujnost
        {
            get { return dlujnost; }
            set { dlujnost = value; }
        }
        /* public string Disciplini
         {
             get { return disciplini; }
             set { disciplini = value; }
         }*/
        public void Disciplini()
        {
            for (int i = 0; i < disciplini.Length; i++)
            {
                Console.WriteLine($"Disciplina {i+1}: ");
                disciplini[i] = Console.ReadLine();
            }
        }
        private Random rnd = new Random();
        public string Programa()
        {
            string[] denotsedmicata = new string[5] {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
            for (int i = 0; i < denotsedmicata.Length; i++)
            {
                int rand = rnd.Next(1, 5);
                switch (rand)
                {
                    case 1:
                        denotsedmicata[i] += $": {disciplini} from 8:00 to 10:00";
                        break;
                    case 2:
                        denotsedmicata[i] += $": {disciplini} from 10:00 to 12:00";
                        break;
                    case 3:
                        denotsedmicata[i] += $": {disciplini} from 12:00 to 14:00";
                        break;
                    case 4:
                        denotsedmicata[i] += $": {disciplini} from 14:00 to 16:00";
                        break;
                }
                    
            }
            string prog = denotsedmicata[0] + "\n" + denotsedmicata[1] + "\n" + denotsedmicata[2] + "\n" + denotsedmicata[3] + "\n" + denotsedmicata[4];
            return prog;
        }
        
    }
}
