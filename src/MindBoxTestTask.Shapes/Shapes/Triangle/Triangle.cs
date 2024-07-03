namespace MindBoxTestTask.Shapes.Shapes.Triangle;

public class Triangle : ITriangle
{
    public Triangle(double sideA, double sideB, double sideC)
    {
        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            throw new ArgumentException("Sides must be positive numbers.");

        if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
            throw new ArgumentException("The given sides do not form a triangle.");

        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }
    
    public double SideA { get; }
    public double SideB { get; }
    public double SideC { get; }
    
    public bool IsRightTriangle()
    {
        List<double> sides = [SideA, SideB, SideC];
        sides.Sort();
        
        return Math.Abs(sides[2] * sides[2] - (sides[0] * sides[0] + sides[1] * sides[1])) < 1e-10;
    }

    public double CalculateArea()
    {
        var s = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
    }
}