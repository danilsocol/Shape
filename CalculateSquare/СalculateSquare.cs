using Shape;

namespace CalculateSquare;

public static class СalculateSquare
{
    public static double Calculate(Figure figure)
    {
        switch (figure)
        {
            case Circle circle:
                return СalculateSquareCircle(circle);
            
            case Triangle triangle:
                return СalculateSquareTriangle(triangle);
        }

        return 0;
    }

    private static double СalculateSquareCircle(Circle circle)
    {
        return Math.Round(3.14 * Math.Pow(circle.Radius,2),2) ;
    }
    
    private static double СalculateSquareTriangle(Triangle triangle)
    {
        double[] sides = triangle.Sides;
        double p = (sides[0] + sides[1] + sides[2]) / 2;
        
        return Math.Round(Math.Sqrt(p * (p - sides[0]) * (p - sides[1]) * (p - sides[2])),2) ;
    }
    
}