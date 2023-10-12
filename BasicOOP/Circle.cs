using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP
{
    internal class Circle
    {

        // property Radius
        public int Radius { get; set; }
        
        // constructor
        public Circle(int radius)
        {
            Radius = radius;
        }
        
        // the one and only method
        public double GetArea()
        {
            double area = Math.PI * Math.Pow(Radius, 2);
            Console.WriteLine($"Circle with radius {Radius} has an area of {area:0.##}");
            return area;
        }
    }
}
