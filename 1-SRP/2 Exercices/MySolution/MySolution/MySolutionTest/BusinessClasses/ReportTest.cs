using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySolution.BusinessClasses;
using System.Collections.Generic;

namespace MySolutionTest
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
    }
}
