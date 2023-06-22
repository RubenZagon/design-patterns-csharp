using VisitorPattern.Shapes;

namespace VisitorPattern.Visitor;

public class CalculateArea : IVisitor
{
    private double _result;

    public void Visit(Circle circle)
    {
        _result = Math.PI * circle.Radius * circle.Radius;
    }

    public void Visit(Rectangle rectangle)
    {
        _result = rectangle.Length * rectangle.Width;
    }
    
    public double GetResult()
    {
        return _result;
    }
}