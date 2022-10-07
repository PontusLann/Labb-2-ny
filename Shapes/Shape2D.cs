using System.Globalization;

namespace Shapes
{

    public abstract class Shape2D : Shape
    {
        public abstract float CircumFerence { get; }

        public abstract string Shape { get; }

        public float Height;

        public float Width;

        public float WidthSquare;

        public float Radius;
        public override string ToString() => $"{Shape} @({Center.X.ToString("f1", commaToDot)}, {Center.Y.ToString("f1", commaToDot)})";
    }
}
