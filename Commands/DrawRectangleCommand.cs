using CommandPatternDrawingApp.Models;

namespace CommandPatternDrawingApp.Commands;

public class DrawRectangleCommand : ICommand
{
    private readonly List<Shape> shapes;
    private readonly RectangleShape rectangle;

    public DrawRectangleCommand(List<Shape> shapes)
    {
        this.shapes = shapes;
        rectangle = new RectangleShape();
    }

    public void Execute()
    {
        shapes.Add(rectangle);
    }

    public void Undo()
    {
        shapes.Remove(rectangle);
    }
}
