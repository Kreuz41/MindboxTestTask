namespace MindBoxTestTask.Shapes.Shapes.Circle;

public class Circle : ICircle
{
    public Circle(double radius)
    {
        if (radius < 0)
            throw new ArgumentException("Radius cannot be negative");
        
        Radius = radius;
    }
    
    public double Radius { get; }
    
    public double CalculateArea() =>
        Math.PI * Radius * Radius;
}