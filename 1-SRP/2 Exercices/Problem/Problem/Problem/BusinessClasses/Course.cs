namespace Problem.BusinessClasses
{
    public class Course
    {
        public string Name { get; set; }
        public int Students { get; set; }
        public double Rating { get; set; }

        public Course(string name, int students, double rating)
        {
            Name = name;
            Students = students;
            Rating = rating;
        }
    }
}
