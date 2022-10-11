namespace Shapes
{

    public abstract class Shape3D : Shape
    {
        public abstract float Volume { get; }

        public override string ToString() => $"{Shapes} @({Center.X.ToString("f1", commaToDot)}, {Center.Y.ToString("f1", commaToDot)}, {Center.Z.ToString("f1", commaToDot)})";

    }
}
