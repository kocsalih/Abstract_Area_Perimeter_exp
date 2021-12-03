using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            

            
            Rectangle r1 = new Rectangle(2,6);
            r1.calculateArea();

            Circle C1 = new Circle(5);
            C1.calculatePerimeter();


            Console.WriteLine(C1.Perimeter);
            Console.WriteLine(r1.Area);

            Console.ReadKey();
        }

    }
}
