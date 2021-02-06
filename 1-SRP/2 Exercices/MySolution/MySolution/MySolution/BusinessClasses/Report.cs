using System;
using System.Collections.Generic;
using System.Linq;

namespace MySolution.BusinessClasses
{
    public class Report
    {
        private readonly List<Course> _courses;

        public List<Course> Courses => _courses;

        public Report()
        {
            _courses = new List<Course>();
        }

        public Report(List<Course> courses)
        {
            _courses = courses;
        }

        public void AddCourse(Course course) => Courses.Add(course);
        public void RemoveCourseAt(int index) => Courses.RemoveAt(index);
        public override string ToString() =>
            string.Join(Environment.NewLine, Courses.Select(x => $"Curso: {x.Name}, Estudiantes: {x.Students}, Valoración: {x.Rating}"));    
    }
}
