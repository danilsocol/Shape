using CalculateSquare;
using NUnit.Framework;
using Shape;

namespace Tests;

public class Tests
{
    [Test]
    public void TestCircleSquare()
    {
        var circle = new Circle(1);
        Assert.That(СalculateSquare.Calculate(circle), Is.EqualTo(3.14));
    }
    
    [Test]
    public void TestTriangleType()
    {
        var triangle = new Triangle(5,5,5);
        Assert.That(triangle.Type, Is.EqualTo(Triangle.TriangleType.Equilateral_triangle));
    }

    [Test]
    public void TestTriangleSquare()
    {
        var triangle = new Triangle(5,4,3);
        Assert.That(СalculateSquare.Calculate(triangle), Is.EqualTo(6));
    }
}