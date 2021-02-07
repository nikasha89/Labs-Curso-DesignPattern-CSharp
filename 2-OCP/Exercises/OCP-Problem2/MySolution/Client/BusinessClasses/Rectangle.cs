namespace Client.BusinessClasses
{
  public class Rectangle : IShape
  {
        public const string ShapeName = "Rectangulo";
        
        public double Width { get; set; }
        public double Height { get; set; }

        public double Area()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return $"{ShapeName}: " + Area();
        }
    }
}