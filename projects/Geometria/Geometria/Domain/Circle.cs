
using Geometria.Domain.Enums;

namespace Geometria.Domain {
    public class Circle : AbstractShape {

        public static readonly double PI = 3.14159265;
        public double Radius { get; set; }

        public Circle(double thick, Color color, double radius) 
            : base(thick, color){
            Radius = radius;
        }

        public override double Perimeter() => 2 * PI * Radius;
        public override double Area() => PI * Radius * Radius;

    }
}
