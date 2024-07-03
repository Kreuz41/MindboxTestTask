using MindBoxTestTask.Shapes.Shapes;

namespace MindBoxTestTask.Shapes.Calculator.ShapeAreaCalculators;

public interface IShapeAreaCalculator
{
    double CalculateArea(IShape shape);
}