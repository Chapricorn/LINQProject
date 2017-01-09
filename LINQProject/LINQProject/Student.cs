using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExpressions
{
    class Student
    {

        List<int> Kolin;
        List<int> Colleen;
        List<int> Caleb;
        List<int> Creg;

        double kolinAverage;
        double colleenAverage;
        double calebAverage;
        double cregAverage;

        public Student()
        {
            Kolin = new List<int> { 90, 85, 95, 70, 80 };
            Colleen = new List<int> { 90, 85, 95, 70, 80 };
            Caleb = new List<int> { 100, 95, 95, 70, 70 };
            Creg = new List<int> { 95, 90, 95, 70, 75 };
        }
        public void GetKolinScore()
        {

            foreach (int item in Kolin.OrderBy(item => item))
                Console.WriteLine("Kolin's Score: " + item);
            Console.WriteLine(" \n");
        }
        public void GetColleenScore()
        {
            foreach (int item in Colleen.OrderBy(item => item))
                Console.WriteLine("Colleen's Score: " + item);
            Console.WriteLine(" \n");
        }
        public void GetCalebScore()
        {
            foreach (int item in Caleb.OrderBy(item => item))
                Console.WriteLine("Caleb's Score: " + item);
            Console.WriteLine(" \n");
        }
        public void GetCregScore()
        {
            foreach (int item in Creg.OrderBy(item => item))
                Console.WriteLine("Creg's Score: " + item);
            Console.WriteLine(" \n");
        }
        public void ShowAllScores()
        {
            GetKolinScore();
            GetColleenScore();
            GetCalebScore();
            GetCregScore();
        }
        public void RemoveLowestScore()
        {
            Kolin.Remove(Kolin.Min());
            Colleen.Remove(Colleen.Min());
            Caleb.Remove(Caleb.Min());
            Creg.Remove(Creg.Min());

        }
        public void GetAverageScores()
        {
            double average = (kolinAverage + colleenAverage + calebAverage + cregAverage) / 4;
            Console.WriteLine(average);
        }
        public void AverageScores()
        {
            Console.WriteLine("\nKolin's's average: ");
            Console.WriteLine(kolinAverage);
            Console.WriteLine("\ncolleen's average:");
            Console.WriteLine(colleenAverage);
            Console.WriteLine("\ncaleb's average:");
            Console.WriteLine(calebAverage);
            Console.WriteLine("\ncreg's average:");
            Console.WriteLine(cregAverage);
        }
        public void GetAverages()
        {
            kolinAverage = Kolin.Average();
            colleenAverage = Colleen.Average();
            calebAverage = Caleb.Average();
            cregAverage = Creg.Average();

        }
    }
}

