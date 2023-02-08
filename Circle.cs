using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution2Group11
{
    public class Circle
    {
        private int radius;
        public Circle()
        {
            radius = 1;
        }
        public Circle(int radius)
        {
            this.radius = radius;
        }
        public int GetRadius()
        {
            return radius;
        }
        public void SetRadius(int radius)
        {
            this.radius = radius;
        }
        public double GetCircumference()
        {
            double circumference = 2 * 3.14 * radius;
            return circumference;
        }
        public double GetArea()
        {
            double area = 3.14 * radius * radius;
            return area;
        }

    }
}
