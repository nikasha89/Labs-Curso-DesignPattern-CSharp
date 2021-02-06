using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem.BusinessClasses;
using System.Collections.Generic;
using System.IO;

namespace ProblemTest
{
    [TestClass]
    public class ReportTest
    {
        private Report report;
        private List<Course> courses;

        [TestInitialize]
        public void Initialize()
        {
            courses = new List<Course> {
                new Course("Patrones de diseño", 1000, 5),
                new Course("Flutter", 1900, 4.5)
            };            
        }

        [TestMethod]
        public void TestAddCourse_TwoCourses_2CoursesAddedToReportList()
        {
            report = new Report();

            Assert.AreEqual(0, report.Courses.Count);
            
            foreach (var course in courses)
                report.AddCourse(course);

            Assert.AreEqual(2, report.Courses.Count);
        }

        [TestMethod]
        public void TestRemoveCourseAt_TwoCourses_1CourseRemovedFromReportList()
        {
            report = new Report(courses);
            
            Assert.AreEqual(2, report.Courses.Count);

            report.RemoveCourseAt(0);

            Assert.AreEqual(1, report.Courses.Count);
        }

        [TestMethod]
        public void TestSaveToFile_TwoCourses_2FilesSaved()
        {
            report = new Report(courses);

            report.SaveToFile("Report","LaPaca");

            Assert.IsTrue(File.Exists(Path.Combine("Report", "LaPaca")));
        }
    }
}
