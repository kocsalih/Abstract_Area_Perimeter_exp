using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractOrnek
{
    public class Square:Shape
    {
        private double _side;

        public double Side
        {
            get { return _side; }
            set { _side = value; }
        }

        public override void calculateArea()
        {
            this.Area = _side * _side;
        }

        public override void calculatePerimeter()
        {
            Perimeter = 4 * Side;
        }


        public Square(double side)
        {
            _side = side;
        }
    }
}
