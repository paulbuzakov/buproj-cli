using BUPROJ.CLI.Commands;

namespace BUPROJ.CLI;

internal static class Program {

    public static void Main(params string[] args) {
        var command = CommandFactory.Create(args);
        command.Execute(args);
    }
}