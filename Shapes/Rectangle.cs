using System.Numerics;

namespace Shapes
{

    public class Rectangle : Shape2D
    {
        public override string Shapes => IsSquare ? "Square" : "Rectangle";

        private float _circumFerence;
        public override float CircumFerence => _circumFerence;

        private Vector3 _center;
        public override Vector3 Center => _center;

        private float _area;
        public override float Area => _area;

        public float Height;

        public float Width;

        public float WidthSquare;

        public bool IsSquare
        {
            get
            {
                if (Height == Width)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

        public Rectangle(Vector2 center, Vector2 size)
        {

            this._center = new Vector3(center.X, center.Y, 0.0f);

            this._area = size.X * size.Y;

            this._circumFerence = (size.X * 2) + (size.Y * 2);

            Height = size.Y;

            Width = size.X;

            AverageArea = (int)_area;

            RectangleCount++;
        }

        public Rectangle(Vector2 center, float width)
        {
            this._center = new Vector3(center.X, center.Y, 0.0f);

            this._area = width * width;

            this._circumFerence = (width * 2) + (width * 2);

            WidthSquare = width;

            AverageArea += (int)_area;

            SquareCount++;
        }

        public override string ToString()
        {
            if (IsSquare)
            {
                return base.ToString() + $"w:h: {WidthSquare.ToString("f1", commaToDot)}cm";
            }
            else
            {
                return base.ToString() + $"w: {Width.ToString("f1", commaToDot)}cm h: {Height.ToString("f1", commaToDot)}cm";
            }
        }
    }
}
