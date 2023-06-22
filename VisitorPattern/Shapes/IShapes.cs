using VisitorPattern.Visitor;

namespace VisitorPattern.Shapes;

public interface IShape
{
    void Accept(IVisitor visitor);
}