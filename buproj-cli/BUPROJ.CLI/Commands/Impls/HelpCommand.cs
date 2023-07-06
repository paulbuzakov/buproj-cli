namespace BUPROJ.CLI.Commands.Impls;

internal class HelpCommand : ICommand
{
    public void Execute(string[] args)
    {
        Console.WriteLine("Hi there!");
        Console.WriteLine("I wish you a productive day");
        Console.WriteLine("BUPROJ CLI is simpler console application for project and task management.");
        Console.WriteLine("List of commands:");
        Console.WriteLine("");
        Console.WriteLine("1. [--project-list/-pl] [folder/current] - show list of projects in current folder");
        Console.WriteLine("2. [--task-list/-tl] [project's filename] - show list of tasks in current project");
        Console.WriteLine("");
        Console.WriteLine("https://github.com/paulbuzakov/buproj-cli");
        Console.WriteLine("email: buzakovpa@gmail.com");
    }
}
