namespace Shapes
{

    public abstract class Shape3D : Shape
    {
        public abstract float Volume { get; }

        public abstract string Shape { get; }

        public float Radius;

        public float Height;

        public float Width;

        public float Length;

        public float WidthCube;

        public override string ToString() => $"{Shape} @({Center.X.ToString("f1", commaToDot)}, {Center.Y.ToString("f1", commaToDot)}, {Center.Z.ToString("f1", commaToDot)})";

    }
}
