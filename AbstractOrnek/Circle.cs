using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractOrnek
{
    public class Circle:Shape
    {
        private double _radius;

        public double Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }



        public override void calculateArea()
        {
            this.Area = Math.PI * Math.Pow(_radius,2);
        }

        public override void calculatePerimeter()
        {
            Perimeter = 2 *Math.PI * _radius;
        }

        public Circle(double radius)
        {
            _radius = radius;
        }

        public Circle()
        {

        }
    }
}
