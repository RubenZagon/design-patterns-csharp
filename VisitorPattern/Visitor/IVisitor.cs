using VisitorPattern.Shapes;

namespace VisitorPattern.Visitor;

public interface IVisitor
{
    void Visit(Circle circle);
    void Visit(Rectangle rectangle);
}