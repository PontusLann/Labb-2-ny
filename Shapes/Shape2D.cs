using System.Globalization;

namespace Shapes
{

    public abstract class Shape2D : Shape
    {
        public abstract float CircumFerence { get; }

        public override string ToString() => $"{Shapes} @({Center.X.ToString("f1", commaToDot)}, {Center.Y.ToString("f1", commaToDot)})";
    }
}
