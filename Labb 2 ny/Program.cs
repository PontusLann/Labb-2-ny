using Shapes;
using static Shapes.Shape;

Shape[] shapes = new Shape[20];


for (int i = 0; i < shapes.Length; i++)
{

    shapes[i] = Shape.GenerateShape();
    Console.WriteLine(shapes[i]);
}
Console.WriteLine();
PrintAveregeArea();
Console.WriteLine();
PrintBiggestVolume();
Console.WriteLine();
PrintMostOccurred();



/// Metoder ///

void PrintAveregeArea()
{
    float averageOfAllShapes = 0;
    float averageArea = 0;
    for (int i = 0; i < shapes.Length; i++)
    {

        averageArea += shapes[i].Area;
    }
    averageOfAllShapes = averageArea / shapes.Length;

    Console.WriteLine($"The average area for all shapes is {averageOfAllShapes}cm^2");
}

void PrintBiggestVolume()
{
    if (CubeVolume > CuboidVolume && CubeVolume > SphereVolume)
    {
        Console.WriteLine($"The shape with biggest volume was Cube and the volume were: {CubeVolume}cm^3");
    }
    else if (CuboidVolume > CubeVolume && CuboidVolume > SphereVolume)
    {
        Console.WriteLine($"The shape with biggest volume was Cuboid and the volume were: {CuboidVolume}cm^3");
    }
    else if (SphereVolume > CubeVolume && SphereVolume > CuboidVolume)
    {
        Console.WriteLine($"The shape with biggest volume was Sphere and the volume were: {SphereVolume}cm^3");
    }
}

void PrintMostOccurred()
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