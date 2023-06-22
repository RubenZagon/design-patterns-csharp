using VisitorPattern.Visitor;

namespace VisitorPattern.Shapes;

public class Rectangle : IShape
{
    public double Length { get; }
    public double Width { get; }

    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}