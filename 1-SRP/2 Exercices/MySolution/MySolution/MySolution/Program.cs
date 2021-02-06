using MySolution.BusinessClasses;
using System;

namespace MySolution
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var report = new Report();
            report.AddCourse(new Course ("Patrones de diseño", 1000, 5));
            report.AddCourse(new Course ("Flutter", 1900, 4.5));

            string reportContent = report.ToString();
            Console.WriteLine(reportContent);

            StaticFile.SaveToFile(@"Reports", "WorkReport.txt", reportContent);
        }
    }
}
