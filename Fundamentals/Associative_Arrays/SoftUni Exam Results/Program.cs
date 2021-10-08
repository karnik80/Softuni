using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Student> students = new Dictionary<string, Student>();
            Dictionary<string, int> langCount = new Dictionary<string, int>();  //lang, submission

            string input = string.Empty;

            while((input = Console.ReadLine()) != "exam finished")
            {
                string[] token = input.Split("-");
                string name = token[0];

                if(token.Length > 2)//normal input
                {
                    string lang = token[1];
                    int points = int.Parse(token[2]);

                    if (students.ContainsKey(name))
                    {
                        if(points > students[name].Points)
                        {
                            students[name].Points = points;
                        }
                        //Check for Lang Submission
                        if (langCount.ContainsKey(lang))
                        {
                            langCount[lang]++;
                        }
                        else
                        {
                            langCount.Add(lang, 1);
                        }
                    }
                    else
                    {
                        students.Add(name, new Student(name, points));
                        //Check for Lang Submission
                        if (langCount.ContainsKey(lang))
                        {
                            langCount[lang]++;
                        }
                        else
                        {
                            langCount.Add(lang, 1);
                        }
                    }
                }
                else
                {
                    string command = token[1];
                    if(command == "banned")
                    {
                        if (students.ContainsKey(name))
                        {
                            students[name].Ban = true;
                        }
                    }
                }
            }

            //students.OrderByDescending(x => x.Value.Points)
            //        .ThenBy(x => x.Key)
            //        .ToDictionary(a => a.Key, b => b.Value);

            Dictionary<string, int> studPoint = new Dictionary<string, int>();//name, points

            foreach (var pair in students)
            {
                if(pair.Value.Ban == false)
                {
                    if (!studPoint.ContainsKey(pair.Key))
                    {
                        studPoint.Add(pair.Key, pair.Value.Points);
                    }
                }
            }

            studPoint = studPoint.OrderByDescending(x => x.Value).ThenBy(x => x.Key)
                                 .ToDictionary(a => a.Key, b => b.Value);
            Console.WriteLine("Results:");
            foreach (var pair in studPoint)
            {
                Console.WriteLine($"{pair.Key} | {pair.Value}");
            }

            //Print language submissions
            Console.WriteLine("Submissions:");
            langCount = langCount.OrderByDescending(x => x.Value)
                                .ThenBy(x => x.Key)
                                .ToDictionary(a => a.Key, b => b.Value);
            foreach (var pair in langCount)
            {
                Console.WriteLine($"{pair.Key} - {pair.Value}");
            }
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public int Points { get; set; }
        public bool Ban { get; set; }

        public Student(string name, int points)
        {
            Name = name;
            Points = points;
            Ban = false;
        }
    }
}
