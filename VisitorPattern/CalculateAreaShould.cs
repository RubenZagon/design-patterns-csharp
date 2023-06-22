using VisitorPattern.Shapes;
using VisitorPattern.Visitor;

namespace VisitorPattern;

public class CalculateAreaShould
{
    [Fact]
    public void Calculate_Circle_Area() {
        var circle = new Circle(3);
        var visitor = new CalculateArea();

        circle.Accept(visitor);

        visitor.GetResult().Should().BeApproximately(28.27, 2);
    }

    [Fact]
    public void Calculate_Rectangle_Area() {
        var rectangle = new Rectangle(3, 4);
        var visitor = new CalculateArea();

        rectangle.Accept(visitor);

        visitor.GetResult().Should().Be(12);
    }
}