using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractOrnek
{
    public abstract class Shape
    {
        private double _area;
        private string _color;
        private double _perimeter;

        public double Area { get { return _area; } set { _area = value; } }
        public string Color { get { return _color; } set { _color = value; } }
        public double Perimeter { get { return _perimeter; } set { _perimeter = value; } }

        public abstract void calculateArea();
        public abstract void calculatePerimeter();


        public Shape()
        {

        }

        //probfull
    }
}
