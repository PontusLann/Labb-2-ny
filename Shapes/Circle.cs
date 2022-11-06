using System.Numerics;

namespace Shapes
{

    public class Circle : Shape2D
    {
        private string _shape = "Circle";
        public override string Shapes => _shape;

        private float _circumFerence;
        public override float CircumFerence => _circumFerence;

        private Vector3 _center;
        public override Vector3 Center => _center;

        private float _area;
        public override float Area => _area;

        public float Radius;

        public Circle(Vector2 center, float radius)
        {
            this._center = new Vector3(center.X, center.Y, 0.0f);

            this._area = (MathF.Pow(radius, 2) * MathF.PI);

            this._circumFerence = (radius * 2f * MathF.PI);

            Radius = radius;

            CircleCount++;
        }

        public override string ToString() => base.ToString() + $"r: {Radius:f2}cm   area:{_area}";
    }
}
