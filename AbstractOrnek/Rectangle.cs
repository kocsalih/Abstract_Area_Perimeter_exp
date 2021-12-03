using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractOrnek
{
   public class Rectangle:Shape
    {

        private double _height;

        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }

        private double _width;

        public double Width
        {
            get { return _width; }
            set { _width = value; }
        }

       
        public override void calculateArea()
        {
            this.Area = _height * _width;
        }

        public override void calculatePerimeter()
        {
            this.Perimeter = (_height * 2) + (_width * 2);
        }

        public Rectangle(double Height,double Width)
        {
            _height = Height;
            _width = Width;
        }

        public Rectangle()
        {

        }
    }
}
