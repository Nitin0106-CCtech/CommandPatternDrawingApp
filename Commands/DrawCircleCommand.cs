using CommandPatternDrawingApp.Models;

namespace CommandPatternDrawingApp.Commands;

public class DrawCircleCommand : ICommand
{
    private readonly List<Shape> shapes;
    private readonly CircleShape circle;

    public DrawCircleCommand(List<Shape> shapes)
    {
        this.shapes = shapes;
        circle = new CircleShape();
    }

    public void Execute()
    {
        shapes.Add(circle);
    }

    public void Undo()
    {
        shapes.Remove(circle);
    }
}
