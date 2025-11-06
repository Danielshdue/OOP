using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._11._25
{
    class Birthday
    {
        private int day, month, year;
        public Birthday()
        {
            day = 0;
            month = 0;
            year = 0;
        }
        public Birthday(int day,int month,int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public int Day
        {
            get { return day; }
            set { day = value; }
        }
        public int Month
        {
            get { return month; }
            set { month = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public void EnterBirhday()
        {
            Console.Write("Day of birth: ");
            this.Day = int.Parse(Console.ReadLine());
            Console.Write("Month of birth: ");
            this.Month = int.Parse(Console.ReadLine());
            Console.Write("Year of birth: ");
            this.Year = int.Parse(Console.ReadLine());
        }
        public string ReturnBirthday()
        {
            return $"My birthday is: {Day}:{Month}:{Year}g.";
        }
        private bool CheckYear()
        {
            bool check = false;
            if (Year % 4 == 0)
            {
                if (Year % 100 != 0 || Year % 400 == 0) check = true;
            }
            return check;
        }
        public static string FindZodiq(Birthday a)
        {
           // string[] spisukzodii = new string[] { "Aries", "Taurus", "Gemini", "Cancer", "Leo", "Virgo", "Libra", "Scorpius", "Sagittarius", "Capricornus", "Aquarius", "Pisces" };
            int feb;
            if (a.CheckYear() == true) feb = 29;
            else feb = 28;
            int[] dnimesec = new int[] { 31, feb, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int[] mesec = new int[11];
            for (int i = 0;i<mesec.Length;i++)
            {
                for (int j = 0; j < (i + 1); j++)
                {
                    mesec[i] += dnimesec[j];
                }
            }
            int chovekbr = a.Day;
            if (a.Month == 1)
            {
                chovekbr += 0;
            }
            else
            {
                for (int i = 0; i < a.Month - 1; i++)
                { 
                    chovekbr += dnimesec[i];
                }
            }
            string zodiq=null;
            if(chovekbr>=1&&chovekbr<=mesec[0]+)
            return zodiq;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Birthday me = new Birthday();
            me.EnterBirhday();
            Console.WriteLine(me.ReturnBirthday()); 
        }
    }
}
