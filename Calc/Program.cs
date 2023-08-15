// See https://aka.ms/new-console-template for more information

using System.ComponentModel;

public class Program
{
    public static void Main(string[] args)
    {

        Triangle t = new Triangle(3, 4, 5);
        Console.WriteLine(t.IsRightTriangle());
        

    }
}
public interface IShape
{
    double CalculateArea();
}

public class Circle : IShape
{
    private readonly double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * _radius * _radius;
    }
}

public class Triangle : IShape
{
    private readonly double _sideOne;
    private readonly double _sideTwo;
    private readonly double _sideThree;

    public Triangle(double a, double b, double c)
    {
        _sideOne = a;
        _sideTwo = b;
        _sideThree = c;
    }

    public double CalculateArea()
    {
        double s = (_sideOne + _sideTwo + _sideThree) / 2;
        return Math.Sqrt(s * (s - _sideOne) * (s - _sideTwo) * (s - _sideThree));
    }

    public bool IsRightTriangle()
    {
        double[] sides = new double[] { _sideOne, _sideTwo, _sideThree };
        Array.Sort(sides);
        return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
    }
}