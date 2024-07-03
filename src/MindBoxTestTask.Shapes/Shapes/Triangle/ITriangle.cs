namespace MindBoxTestTask.Shapes.Shapes.Triangle;

public interface ITriangle : IShape
{
    double SideA { get; }
    double SideB { get; }
    double SideC { get; }
    
    bool IsRightTriangle();
}