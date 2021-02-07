using System.Collections.Generic;

namespace Client.BusinessClasses
{
    public class AreaCalculator
  {
        public string AreaMessage(IShape shape)
        {   
            return shape.ToString();
        }
        public List<string> AreaMessage(List<IShape> shapes)
        {
            List<string> area = new List<string>();
            foreach (var shape in shapes)
            {
                area.Add(AreaMessage(shape));
            }

            return area;
        }
  }
}