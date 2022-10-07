using System.Diagnostics.Metrics;
using System.Globalization;
using System.Numerics;

namespace Shapes
{

    public abstract class Shape
    {
        public abstract Vector3 Center { get; }

        public abstract float Area { get; }

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
                    Console.WriteLine("--------------------------Circel-----------------------------------");
                    return new Circle(new Vector2(centerPoint.X, centerPoint.Y), Math.Abs(RandomValue()));
                case (AllShapes)1:
                    Console.WriteLine("--------------------------Rectangle--------------------------------");
                    return new Rectangle(new Vector2(centerPoint.X, centerPoint.Y), new Vector2(Math.Abs(RandomValue()), Math.Abs(RandomValue())));
                case (AllShapes)2:
                    Console.WriteLine("--------------------------Square-----------------------------------");
                    return new Rectangle(new Vector2(centerPoint.X, centerPoint.Y), Math.Abs(RandomValue()));
                case (AllShapes)3:
                    Console.WriteLine("--------------------------Triangle---------------------------------");
                    return new Triangle(new Vector2(RandomValue(), RandomValue()), new Vector2(RandomValue(), RandomValue()), new Vector3(centerPoint.X, centerPoint.Y, 0.0f));
                case (AllShapes)4:
                    Console.WriteLine("--------------------------Cuboid-----------------------------------");
                    return new Cuboid(new Vector3(centerPoint.X, centerPoint.Y, centerPoint.Z), new Vector3(Math.Abs(RandomValue()), Math.Abs(RandomValue()), Math.Abs(RandomValue())));
                case (AllShapes)5:
                    Console.WriteLine("--------------------------Cube-------------------------------------");
                    return new Cuboid(new Vector3(centerPoint.X, centerPoint.Y, centerPoint.Z), Math.Abs(RandomValue()));
                case (AllShapes)6:
                    Console.WriteLine("--------------------------Sphere-----------------------------------");
                    return new Sphere(new Vector3(centerPoint.X, centerPoint.Y, centerPoint.Z), Math.Abs(RandomValue()));
                default:
                    return GenerateShape();

            };

        }

        public static Shape GenerateShape()
        {

            switch (RandomShape())
            {
                case 0:
                    Console.WriteLine("--------------------------Circel-----------------------------------");
                    return new Circle(new Vector2(RandomValue(), RandomValue()), Math.Abs(RandomValue()));
                case (AllShapes)1:
                    Console.WriteLine("--------------------------Rectangle--------------------------------");
                    return new Rectangle(new Vector2(RandomValue(), RandomValue()), new Vector2(Math.Abs(RandomValue()), Math.Abs(RandomValue())));
                case (AllShapes)2:
                    Console.WriteLine("--------------------------Square-----------------------------------");
                    return new Rectangle(new Vector2(RandomValue(), RandomValue()), Math.Abs(RandomValue()));
                case (AllShapes)3:
                    Console.WriteLine("--------------------------Triangle---------------------------------");
                    return new Triangle(new Vector2(RandomValue(), RandomValue()), new Vector2(RandomValue(), RandomValue()), new Vector2(RandomValue(), RandomValue()));
                case (AllShapes)4:
                    Console.WriteLine("--------------------------Cuboid-----------------------------------");
                    return new Cuboid(new Vector3(RandomValue(), RandomValue(), RandomValue()), new Vector3(Math.Abs(RandomValue()), Math.Abs(RandomValue()), Math.Abs(RandomValue())));
                case (AllShapes)5:
                    Console.WriteLine("--------------------------Cube-------------------------------------");
                    return new Cuboid(new Vector3(RandomValue(), RandomValue(), RandomValue()), Math.Abs(RandomValue()));
                case (AllShapes)6:
                    Console.WriteLine("--------------------------Sphere-----------------------------------");
                    return new Sphere(new Vector3(RandomValue(), RandomValue(), RandomValue()), Math.Abs(RandomValue()));
                default:
                    return GenerateShape();

            };

        }

        public static void PrintValues()
        {
            AverageArea = AverageArea / 20;
            Console.WriteLine($"Sum of circumference of all triangles: {TriangleCircumference}cm");
            Console.WriteLine();
            Console.WriteLine($"The average area of all shapes: {AverageArea}cm^2");
            Console.WriteLine();
            PrintMostOccurred();
            Console.WriteLine();
            PrintBiggestVolume();
        }

        public static void PrintMostOccurred()
        {
            if (CircleCount >= RectangleCount && CircleCount >= SquareCount && CircleCount >= TriangleCount && CircleCount >= CuboidCount && CircleCount >= CubeCount && CircleCount >= SphereCount)
            {
                Console.WriteLine($"Most occurring shape was Circle and it occurred {CircleCount} Times");
            }
            else if (RectangleCount >= CircleCount && RectangleCount >= SquareCount && RectangleCount >= TriangleCount && RectangleCount >= CuboidCount && RectangleCount >= CubeCount && RectangleCount >= SphereCount)
            {
                Console.WriteLine($"Most occurring shape was Rectangle and it occurred {RectangleCount} Times");
            }
            else if (SquareCount >= CircleCount && SquareCount >= RectangleCount && SquareCount >= TriangleCount && SquareCount >= CuboidCount && SquareCount >= CubeCount && SquareCount >= SphereCount)
            {
                Console.WriteLine($"Most occurring shape was Square and it occurred {SquareCount} Times");
            }
            else if (TriangleCount >= CircleCount && TriangleCount >= RectangleCount && TriangleCount >= SquareCount && TriangleCount >= CuboidCount && TriangleCount >= CubeCount && TriangleCount >= SphereCount)
            {
                Console.WriteLine($"Most occurring shape was Triangle and it occurred {TriangleCount} Times");
            }
            else if (CuboidCount >= CircleCount && CuboidCount >= RectangleCount && CuboidCount >= SquareCount && CuboidCount >= TriangleCount && CuboidCount >= CubeCount && CuboidCount >= SphereCount)
            {
                Console.WriteLine($"Most occurring shape was Cuboid and it occurred {CuboidCount} Times");
            }
            else if (CubeCount >= CircleCount && CubeCount >= RectangleCount && CubeCount >= SquareCount && CubeCount >= TriangleCount && CubeCount >= CuboidCount && CubeCount >= SphereCount)
            {
                Console.WriteLine($"Most occurring shape was Cube and it occurred {CubeCount} Times");
            }
            else if (SphereCount >= CircleCount && SphereCount >= RectangleCount && SphereCount >= SquareCount && SphereCount >= TriangleCount && SphereCount >= CuboidCount && SphereCount >= CubeCount)
            {
                Console.WriteLine($"Most occurring shape was Sphere and it occurred {SphereCount} Times");
            }
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

        public static void PrintBiggestVolume()
        {
            if (SphereVolume >= CuboidVolume && SphereVolume >= CubeVolume)
            {
                if (SphereVolume == CuboidVolume)
                {
                    Console.WriteLine($"The two shapes with biggest volumes are Sphere and Cuboid their volumes were Sphere:{SphereVolume}cm^3, Cuboid:{CuboidVolume}cm^3");
                }
                else if (SphereVolume == CubeVolume)
                {
                    Console.WriteLine($"The two shapes with biggest volumes are Sphere and Cube their volumes were Sphere:{SphereVolume}cm^3, Cuboid:{CubeVolume}cm^3");
                }
                else if (SphereVolume == CuboidVolume && SphereVolume == CubeVolume)
                {
                    Console.WriteLine($"All Shapes had the same volume!! Their volume were {SphereVolume}cm^3");
                }
                else
                {
                    Console.WriteLine($"The shape with biggest volume was Sphere and the volume were: {SphereVolume}cm^3");
                }
            }
            else if (CuboidVolume >= SphereVolume && CuboidVolume >= CubeVolume)
            {
                if (CuboidVolume == SphereVolume)
                {
                    Console.WriteLine($"The two shapes with biggest volumes are Sphere and Cuboid their volumes were Sphere:{SphereVolume}cm^3, Cuboid:{CuboidVolume}cm^3");
                }
                else if (CuboidVolume == CubeVolume)
                {
                    Console.WriteLine($"The two shapes with biggest volumes are Cube and Cuboid their volumes were Cube:{CubeVolume}cm^3, Cuboid:{CuboidVolume}cm^3");
                }
                else if (SphereVolume == CuboidVolume && SphereVolume == CubeVolume)
                {
                    Console.WriteLine($"All Shapes had the same volume!! Their volume were {CuboidVolume}cm^3");
                }
                else
                {
                    Console.WriteLine($"The shape with biggest volume was Cuboid and the volume were: {CuboidVolume}cm^3");
                }

            }
            else if (CubeVolume >= SphereVolume && CubeVolume >= CuboidVolume)
            {
                if (CubeVolume == SphereVolume)
                {
                    Console.WriteLine($"The two shapes with biggest volumes are Sphere and Cube their volumes were Sphere:{SphereVolume}cm^3, Cuboid:{CubeVolume}cm^3");
                }
                else if (CubeVolume == CuboidVolume)
                {
                    Console.WriteLine($"The two shapes with biggest volumes are Cube and Cuboid their volumes were Cube:{CubeVolume}cm^3, Cuboid:{CuboidVolume}cm^3");
                }
                else if (SphereVolume == CuboidVolume && SphereVolume == CubeVolume)
                {
                    Console.WriteLine($"All Shapes had the same volume!! Their volume were {CubeVolume}cm^3");
                }
                else
                {
                    Console.WriteLine($"The shape with biggest volume was Cube and the volume were: {CubeVolume}cm^3");
                }
            }
        }

    }
}
