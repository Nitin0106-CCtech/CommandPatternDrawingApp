using CommandPatternDrawingApp.Commands;

namespace CommandPatternDrawingApp.Managers;

public class CommandManager
{
    private readonly Stack<ICommand> undoStack = new();
    private readonly Stack<ICommand> redoStack = new();

    public void ExecuteCommand(ICommand command)
    {
        command.Execute();

        undoStack.Push(command);

        redoStack.Clear();
    }

    public void Undo()
    {
        if (undoStack.Count == 0)
        {
            Console.WriteLine("Nothing to undo");
            return;
        }

        ICommand command = undoStack.Pop();

        command.Undo();

        redoStack.Push(command);
    }

    public void Redo()
    {
        if (redoStack.Count == 0)
        {
            Console.WriteLine("Nothing to redo");
            return;
        }

        ICommand command = redoStack.Pop();

        command.Execute();

        undoStack.Push(command);
    }
}
