namespace Shape;

public record Triangle : Figure
{
    public double[] Sides { get; private set; } = new double[3];
    public TriangleType Type { get; private set; }

    public enum TriangleType
    {
        Equilateral_triangle,
        Isosceles_triangle,
        Ordinary_triangle
    }
    
    public Triangle(double a,double b,double c)
    {
        Check(a,b,c);
        
        Sides[0] = a;
        Sides[1] = b;
        Sides[2] = c;

        IdentifyType();
    }
    
    public Triangle(double[] sides)
    {
        Check(sides[0],sides[1],sides[2]);
        if (sides.Length != 3)
        {
            throw new Exception("Неправильное количество сторон");
        }
        
        sides.CopyTo(Sides, 0);
        IdentifyType();
    }

    private bool Check(double a,double b,double c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
            throw new Exception("Одна или несколько сторон меньше 0");
        else if (a + b <= c || a + c <= b || b + c <= a)
            throw new Exception("Это не треугольник!");
        
        return true;
    }

    private void IdentifyType()
    {
        if (Sides[0] == Sides[1] && Sides[1] == Sides[2])
            Type = TriangleType.Equilateral_triangle;
        else if (Sides[0] == Sides[1] || Sides[0] == Sides[2] || Sides[1] == Sides[2])
            Type = TriangleType.Isosceles_triangle;
        else
            Type = TriangleType.Ordinary_triangle;
    }
    
}

