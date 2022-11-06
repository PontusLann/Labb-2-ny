using System.Numerics;

namespace Shapes
{

    public class Sphere : Shape3D
    {
        private string _shape = "Sphere";
        public override string Shapes => _shape;

        private float _volume;
        public override float Volume => _volume;

        private Vector3 _center;
        public override Vector3 Center => _center;

        private float _area;
        public override float Area => _area;

        public float Radius;

        public Sphere(Vector3 center, float radius)
        {
            this._center = new Vector3(center.X, center.Y, center.Z);

            this._area = 4f * MathF.PI * (MathF.Pow(radius, 2));

            this._volume = (4f / 3f) * MathF.PI * (MathF.Pow(radius, 3));

            Radius = radius;

            SphereCount++;

            SphereVolume = _volume;
        }



        public override string ToString() => base.ToString() + $"r: {Radius:f2}cm        area: {_area}";
    }
}
