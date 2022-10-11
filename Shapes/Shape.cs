using Shapes;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Numerics;
using static Shapes.Shape;

namespace Shapes
{

    public abstract class Shape
    {
        public abstract Vector3 Center { get; }

        public abstract float Area { get; }

        public abstract string Shapes { get; }

        public static int AverageArea;

        public static int TriangleCircumference;

        public static int CircleCount;

        public static int TriangleCount;

        public static int RectangleCount;

        public static int SquareCount;

        public static int CuboidCount;

        public static int CubeCount;

        public static int SphereCount;

        public static float SphereVolume;

        public static float CuboidVolume;

        public static float CubeVolume;

        public CultureInfo commaToDot = CultureInfo.CreateSpecificCulture("es-US");

        public enum AllShapes
        {
            Circle,
            Rectangle,
            Square,
            Triangle,
            Cuboid,
            Cube,
            Sphere
        }

        public static Shape GenerateShape(Vector3 centerPoint)
        {

            switch (RandomShape())
            {

                case 0:
                    return new Circle(new Vector2(centerPoint.X, centerPoint.Y), Math.Abs(RandomValue()));
                case (AllShapes)1:
                    return new Rectangle(new Vector2(centerPoint.X, centerPoint.Y), new Vector2(Math.Abs(RandomValue()), Math.Abs(RandomValue())));
                case (AllShapes)2:
                    return new Rectangle(new Vector2(centerPoint.X, centerPoint.Y), Math.Abs(RandomValue()));
                case (AllShapes)3:
                    return new Triangle(new Vector2(RandomValue(), RandomValue()), new Vector2(RandomValue(), RandomValue()), new Vector3(centerPoint.X, centerPoint.Y, 0.0f));
                case (AllShapes)4:
                    return new Cuboid(new Vector3(centerPoint.X, centerPoint.Y, centerPoint.Z), new Vector3(Math.Abs(RandomValue()), Math.Abs(RandomValue()), Math.Abs(RandomValue())));
                case (AllShapes)5:
                    return new Cuboid(new Vector3(centerPoint.X, centerPoint.Y, centerPoint.Z), Math.Abs(RandomValue()));
                case (AllShapes)6:
                    return new Sphere(new Vector3(centerPoint.X, centerPoint.Y, centerPoint.Z), Math.Abs(RandomValue()));
                default:
                    return GenerateShape();

            };

        }

        public static Shape GenerateShape()
        {
            return GenerateShape(new Vector3(RandomValue(), RandomValue(), RandomValue()));
        }

        private static float RandomValue()
        {
            Random randomNumberForRandomValue = new();

            return randomNumberForRandomValue.Next(-30, 30);
        }

        private static AllShapes RandomShape()
        {
            Random randomNumberForRandomShape = new();

            var allShapesLength = Enum.GetNames(typeof(AllShapes)).Length;

            int randomNumber = randomNumberForRandomShape.Next(0, allShapesLength);

            AllShapes randomShape = (AllShapes)randomNumber;

            return randomShape;
        }

        

    }
}


