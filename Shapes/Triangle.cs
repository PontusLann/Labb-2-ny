using System.Numerics;

namespace Shapes
{

    public class Triangle : Shape2D
    {
        private string _shape = "Triangle";
        public override string Shape => _shape;

        private float _circumFerence;
        public override float CircumFerence => _circumFerence;

        private Vector3 _center;
        public override Vector3 Center => _center;

        private float _area;
        public override float Area => _area;

        private Vector2 P1;

        private Vector2 P2;

        private Vector2 P3;

        public Triangle(Vector2 p1, Vector2 p2, Vector2 p3)
        {
            P1 = new Vector2(p1.X, p1.Y);

            P2 = new Vector2(p2.X, p2.Y);

            P3 = new Vector2(p3.X, p3.Y);

            float P1C = MathF.Pow((p2.X - p1.X), 2) + MathF.Pow((p2.Y - p1.Y), 2);

            float P2C = MathF.Pow((p3.X - p2.X), 2) + MathF.Pow((p3.Y - p2.Y), 2);

            float P3C = MathF.Pow((p1.X - p3.X), 2) + MathF.Pow((p1.Y - p3.Y), 2);

            float totalCircumference = MathF.Sqrt(P1C) + MathF.Sqrt(P2C) + MathF.Sqrt(P3C);

            this._circumFerence = totalCircumference;

            this._center = new Vector3((p1.X + p2.X + p3.X) / 3, (p1.Y + p2.Y + p3.Y) / 3, 0.0f);

            this._area = MathF.Abs(p1.X * (p2.Y - p3.Y) + p2.Y * (p3.Y - p1.Y) + p3.Y * (p1.Y - p2.Y));

            TriangleCircumference += (int)_circumFerence;

            AverageArea += (int)_area;

            TriangleCount++;
        }

        public Triangle(Vector2 p1, Vector2 p2, Vector3 center)
        {
            P1 = new Vector2(p1.X, p1.Y);

            P2 = new Vector2(p2.X, p2.Y);

            P3 = new Vector2((3 * center.X) - p1.X - p2.X, (3 * center.Y) - p1.Y - p2.Y);

            float P1C = MathF.Pow((p2.X - p1.X), 2) + MathF.Pow((p2.Y - p1.Y), 2);

            float P2C = MathF.Pow((center.X - p2.X), 2) + MathF.Pow((center.Y - p2.Y), 2);

            float P3C = MathF.Pow((p1.X - center.X), 2) + MathF.Pow((p1.Y - center.Y), 2);

            float totalCircumference = MathF.Sqrt(P1C) + MathF.Sqrt(P2C) + MathF.Sqrt(P3C);

            this._circumFerence = totalCircumference;

            this._center = new Vector3((p1.X + p2.X + P3.X) / 3, (p1.Y + p2.Y + P3.Y) / 3, 0.0f);

            this._area = MathF.Abs(p1.X * (p2.Y - P3.Y) + p2.Y * (P3.Y - p1.Y) + P3.Y * (p1.Y - p2.Y));

            TriangleCircumference += (int)_circumFerence;

            AverageArea += (int)_area;

            TriangleCount++;
        }

        public override string ToString() => base.ToString() + $"p1({P1.X.ToString("f1", commaToDot)} {P1.Y.ToString("f1", commaToDot)}), p2({P2.X.ToString("f1", commaToDot)} {P2.Y.ToString("f1", commaToDot)}, p3({P3.X.ToString("f1", commaToDot)} {P3.Y.ToString("f1", commaToDot)})";
    }
}

