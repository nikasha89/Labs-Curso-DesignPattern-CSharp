using Client.BusinessClasses;
using System;
using System.Collections.Generic;

namespace Client
{
  class Program
  {
    static void Main(string[] args)
    {
      var areaCalculator = new AreaCalculator();
      var shapes = new List<IShape>()
      {
          new Rectangle { Width = 40, Height = 20},
          new Circle {Radius = 10}
      };

      Console.WriteLine(string.Join(Environment.NewLine, areaCalculator.AreaMessage(shapes)));
    }
  }
}
