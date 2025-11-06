using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._10._25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of stations: ");
            int broi = int.Parse(Console.ReadLine());
            string[] stancii = new string[broi];
            int[] temp = new int[broi];
            for (int i = 0; i < stancii.Length; i++)
            {
                Console.Write("Station name: ");
                stancii[i] = Console.ReadLine();
                Console.Write("Measured temperature: ");
                temp[i] = int.Parse(Console.ReadLine());
            }
            int mintemp=int.MaxValue;
            foreach (int k in temp)
            {
                if (k < mintemp) mintemp = k;
            }
            int maxtemp = int.MinValue;
            foreach (int k in temp)
            {
                if (k > maxtemp) maxtemp = k;
            }
            string[] minstancii=new string[broi];
            int minindex = 0;
            string[] maxstancii=new string[broi];
            int maxindex = 0;
            int maxLength = 0, minLength = 0;
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] == mintemp)
                {
                    minstancii[minindex] += stancii[i];
                    minLength++;
                    minindex++;
                }
                if (temp[i] == maxtemp)
                {
                    maxstancii[maxindex] += stancii[i];
                    maxLength++;
                    maxindex++;
                }
            }
            if (minLength == 1)
                Console.WriteLine("Lowest temperature: {0}°C, station: {1}", +mintemp, minstancii[0]);
            else
            {
                Console.Write("Lowest temperature: {0}°C, stations: ", +mintemp);
                for (int i = 0; i < minLength; i++)
                {
                    if(i!=minLength-1)
                        Console.Write(minstancii[i]+", ");
                    else
                        Console.WriteLine(minstancii[i]);
                }
            }
            if (maxLength == 1)
                Console.WriteLine("Highest temperature: {0}°C, station: {1}", +maxtemp, maxstancii[0]);
            else
            {
                Console.Write("Highest temperature: {0}°C, stations: ", +maxtemp);
                for (int i = 0; i < maxLength; i++)
                {
                    if (i != maxLength - 1)
                        Console.Write(maxstancii[i] + ", ");
                    else
                        Console.WriteLine(maxstancii[i]);
                }
            }
            Console.WriteLine("Temperature difference: {0}°C",+(maxtemp-mintemp));
        }
    }
}
