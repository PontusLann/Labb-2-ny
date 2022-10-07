using System.Numerics;

namespace Shapes
{

    public class Cuboid : Shape3D
    {
        public override string Shape => IsCube ? "Cube" : "Cuboid";

        public float _volume;
        public override float Volume => _volume;

        public Vector3 _center;
        public override Vector3 Center => _center;

        public float _area;
        public override float Area => _area;

        public bool IsCube
        {
            get
            {
                if (Height == Width && Height == Length)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

        public Cuboid(Vector3 center, Vector3 size)
        {
            this._center = new Vector3(center.X, center.Y, center.Z);

            this._area = 2 * ((size.X * size.Y) + (size.Y * size.Z) + (size.Z * size.X));

            this._volume = MathF.Pow(size.X, 3);

            Height = size.X;

            Width = size.Y;

            Length = size.Z;

            AverageArea += (int)_area;

            CuboidCount++;

            CuboidVolume = _volume;
        }

        public Cuboid(Vector3 center, float width)
        {
            this._center = new Vector3(center.X, center.Y, center.Z);

            this._area = 6f * (MathF.Pow(width, 2));

            this._volume = MathF.Pow(width, 3);

            WidthCube = width;

            AverageArea += (int)_area;

            CubeCount++;

            CubeVolume = _volume;
        }

        public override string ToString()
        {
            if (IsCube)
            {
                return base.ToString() + $"w:h:l: {WidthCube}cm   {_area}";
            }
            else
            {
                return base.ToString() + $"w: {Width}cm h: {Height}cm l: {Length}cm    {_area}";
            }
        }
    }
}