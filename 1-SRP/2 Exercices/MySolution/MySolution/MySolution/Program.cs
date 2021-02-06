using Problem.BusinessClasses;
using System;

namespace Problem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var report = new Report();
            report.AddCourse(new Course ("Patrones de diseño", 1000, 5));
            report.AddCourse(new Course ("Flutter", 1900, 4.5));

            Console.WriteLine(report.ToString());

            report.SaveToFile(@"Reports", "WorkReport.txt");
        }
    }
}
