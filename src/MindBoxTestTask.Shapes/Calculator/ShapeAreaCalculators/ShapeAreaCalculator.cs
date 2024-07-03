using MindBoxTestTask.Shapes.Shapes;

namespace MindBoxTestTask.Shapes.Calculator.ShapeAreaCalculators;

public class ShapeAreaCalculator : IShapeAreaCalculator
{
    public double CalculateArea(IShape shape) =>
        shape.CalculateArea();
}