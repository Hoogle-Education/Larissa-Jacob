using Geometria.Domain.Enums;

namespace Geometria.Domain {
    public abstract class AbstractShape : IShape {

        public double Thick { get; set; }
        public Color Color { get; set; }

        public AbstractShape(double thick, Color color) {
            Thick = thick;
            Color = color;
        }

        public abstract double Perimeter();
        public abstract double Area();

    }
}
