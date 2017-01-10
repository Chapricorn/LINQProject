using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExpressions
{
    public class Program
    {
        public static void Main()
        {
            List<string> list = new List<string>();
            Console.WriteLine(" List of Colors: ");
            list.Add("Blue");
            list.Add("Blue");
            list.Add("Yellow");
            list.Add("Green");
            list.Add("Orange");
            list.Add("Orange");
            list.Add("Black");
            list.Add("Black");
            list.Add("White");

            foreach (string value in list)
            {
                Console.WriteLine("Color: {0}", value);
            }

            List<string> distinct = list.Distinct().ToList();
            Console.WriteLine("\nList of Colors not duplicating: ");

            foreach (string value in distinct)
            {
                Console.WriteLine("Color: {0}", value);
            }
            Console.WriteLine(" \n ");


            Student student = new Student();
            Console.WriteLine(" Student's Project Scores. ");
            student.ShowAllScores();
           

            Console.WriteLine(" Student's scores after lowest score is Removed. ");
            student.RemoveLowestScore();
            student.ShowAllScores();
            Console.WriteLine("\nAverage After removing lowest score:");
            student.GetAverages();
            student.AverageScores();
            Console.WriteLine("\nAverage of all Student's averages:");
            student.GetAverageScores();


            string letterString = "bbbcaaheffgiiih";
            {
                //Console.WriteLine(value);
                //foreach (int letter in letterString.OrderBy(item => item))
                Console.WriteLine("\nString of Letters: " + letterString);

                for (int i = 0; i < letterString.Length; i++)
                {
                    int number = letterString[i];

                }

                var characterCount = new Dictionary<char, int>();
                foreach (var count in letterString.OrderBy(item => item))
                {
                    if (characterCount.ContainsKey(count))
                        characterCount[count]++;
                    else
                        characterCount[count] = 1;
                }
                int aCount = 0;
                characterCount.TryGetValue('a', out aCount);
                Console.WriteLine("\nNumber of Letters in String and in Order: ");

                foreach (var pair in characterCount)
                {
                   
                    Console.WriteLine("{0} - {1}", pair.Key, pair.Value);
                }



                Console.ReadKey();
            }
        }
    }
}


