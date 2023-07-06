namespace BUPROJ.CLI.Commands.Impls;

internal class ProjectListCommand : ICommand
{
    public void Execute(string[] args)
    {
        var path = args.Length >= 2 ? args[1] : ".";
        foreach (var file in Directory.GetFiles(path, "*.buproj"))
        {
            Console.WriteLine(file);
        }
    }
}
