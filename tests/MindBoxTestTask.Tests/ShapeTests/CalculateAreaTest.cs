using MindBoxTestTask.Shapes.Calculator.ShapeAreaCalculators;
using MindBoxTestTask.Shapes.Shapes;
using MindBoxTestTask.Shapes.Shapes.Circle;
using MindBoxTestTask.Shapes.Shapes.Triangle;

namespace Tests.ShapeTests;

[TestFixture]
public class CalculateAreaTest
{
    [TestCase(1, ExpectedResult = Math.PI * 1 * 1)]
    [TestCase(2, ExpectedResult = Math.PI * 2 * 2)]
    [TestCase(3.5, ExpectedResult = Math.PI * 3.5 * 3.5)]
    [TestCase(10, ExpectedResult = Math.PI * 10 * 10)]
    public double CircleAreaTest(double radius)
    {
        var circle = new Circle(radius);
        return circle.CalculateArea();
    }

    [TestCase(3, 4, 5, ExpectedResult = 6)]
    [TestCase(6, 8, 10, ExpectedResult = 24)]
    [TestCase(5, 12, 13, ExpectedResult = 30)]
    [TestCase(7, 24, 25, ExpectedResult = 84)]
    public double TriangleAreaTest(double sideA, double sideB, double sideC)
    {
        var triangle = new Triangle(sideA, sideB, sideC);
        return triangle.CalculateArea();
    }

    [TestCase(3, 4, 5, ExpectedResult = true)]
    [TestCase(6, 8, 10, ExpectedResult = true)]
    [TestCase(5, 12, 13, ExpectedResult = true)]
    [TestCase(7, 24, 25, ExpectedResult = true)]
    public bool RightTriangleTest(double sideA, double sideB, double sideC)
    {
        var triangle = new Triangle(sideA, sideB, sideC);
        return triangle.IsRightTriangle();
    }

    [TestCase(3, 4, 5, ExpectedResult = true)]
    [TestCase(6, 8, 10, ExpectedResult = true)]
    [TestCase(5, 12, 15, ExpectedResult = false)]
    [TestCase(7, 24, 26, ExpectedResult = false)]
    public bool NonRightTriangleTest(double sideA, double sideB, double sideC)
    {
        var triangle = new Triangle(sideA, sideB, sideC);
        return triangle.IsRightTriangle();
    }

    [TestCase(5, 3, 4, 5, ExpectedResult = new[] { Math.PI * 25, 6 })]
    [TestCase(2, 6, 8, 10, ExpectedResult = new[] { Math.PI * 4, 24 })]
    [TestCase(3.5, 5, 12, 13, ExpectedResult = new[] { Math.PI * 3.5 * 3.5, 30 })]
    [TestCase(10, 7, 24, 25, ExpectedResult = new[] { Math.PI * 100, 84 })]
    public double[] ShapeAreaCalculatorTest(double radius, double sideA, double sideB, double sideC)
    {
        IShape circle = new Circle(radius);
        IShape triangle = new Triangle(sideA, sideB, sideC);

        var calculator = new ShapeAreaCalculator();

        return
        [
            calculator.CalculateArea(circle),
            calculator.CalculateArea(triangle)
        ];
    }
}