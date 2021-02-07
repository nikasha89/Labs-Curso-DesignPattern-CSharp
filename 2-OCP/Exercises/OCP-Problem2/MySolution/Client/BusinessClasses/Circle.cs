using System;

namespace Client.BusinessClasses
{
  public class Circle : IShape
  {
        public const string ShapeName = "Circulo";

        public double Radius { get; set; }
        
        public double Area()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }

        public override string ToString()
        {
            return $"{ShapeName}: " + Area();
        }
    }
}