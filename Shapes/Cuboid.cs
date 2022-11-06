using System.Numerics;

namespace Shapes
{

    public class Cuboid : Shape3D
    {
        public override string Shapes => IsCube ? "Cube" : "Cuboid";

        public float _volume;
        public override float Volume => _volume;

        public Vector3 _center;
        public override Vector3 Center => _center;

        public float _area;
        public override float Area => _area;

        public float Height;

        public float Width;

        public float Length;

        public float WidthCube;

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

            this._volume = size.X * size.Y * size.Z;

            Height = size.X;

            Width = size.Y;

            Length = size.Z;

            CuboidCount++;

            CuboidVolume = _volume;
        }

        public Cuboid(Vector3 center, float width)
        {
            this._center = new Vector3(center.X, center.Y, center.Z);

            this._area = 6f * (MathF.Pow(width, 2));

            this._volume = MathF.Pow(width, 3);

            WidthCube = width;

            CubeCount++;

            CubeVolume = _volume;
        }

        public override string ToString()
        {
            if (IsCube)
            {
                return base.ToString() + $"w:h:l: {WidthCube}cm    area:{_area}";
            }
            else
            {
                return base.ToString() + $"w: {Width}cm h: {Height}cm l: {Length}cm    area:{_area}";
            }
        }
    }
}