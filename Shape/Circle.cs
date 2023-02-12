namespace Shape;

public record Circle : Figure
{
    public double Radius { get; private set; }
    
    public Circle(double radius)
    {
        Check(radius);
        Radius = radius;
    }
    
    private bool Check(double radius)
    {
        if (radius <= 0)
        {
            throw new Exception("Радиус меньше 0");
        }

        return true;
    }
}