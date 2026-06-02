using CommandPatternDrawingApp.Commands;
using CommandPatternDrawingApp.Managers;
using CommandPatternDrawingApp.Models;

List<Shape> shapes = new();

CommandManager manager = new();

while (true)
{
    Console.WriteLine("\n===== Drawing App =====");

    Console.WriteLine("1. Draw Circle");
    Console.WriteLine("2. Draw Rectangle");
    Console.WriteLine("3. Undo");
    Console.WriteLine("4. Redo");
    Console.WriteLine("5. Show Canvas");
    Console.WriteLine("6. Exit");

    Console.Write("Choice: ");

    string? choice = Console.ReadLine();

    switch (choice)
    {
        case "1":

            manager.ExecuteCommand(
                new DrawCircleCommand(shapes));

            Console.WriteLine("Circle added");
            break;

        case "2":

            manager.ExecuteCommand(
                new DrawRectangleCommand(shapes));

            Console.WriteLine("Rectangle added");
            break;

        case "3":

            manager.Undo();
            break;

        case "4":

            manager.Redo();
            break;

        case "5":

            Console.WriteLine("\nCanvas:");

            if (shapes.Count == 0)
            {
                Console.WriteLine("Empty");
            }

            for (int i = 0; i < shapes.Count; i++)
            {
                Console.WriteLine(
                    $"{i + 1}. {shapes[i].Name}");
            }

            break;

        case "6":

            return;

        default:

            Console.WriteLine("Invalid choice");
            break;
    }
}
