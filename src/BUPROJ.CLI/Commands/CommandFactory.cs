using BUPROJ.CLI.Commands.Impls;

namespace BUPROJ.CLI.Commands;

internal class CommandFactory {
    private readonly string[] args;

    private CommandFactory(string[] args)
    {
        this.args = args;
    }

    public static ICommand Create(string[] args) {
        var factory = new CommandFactory(args);
        return factory.Build();
    }

    public ICommand Build() {
        if (args.Length <= 0) {
            return new HelpCommand();
        }

        switch(args[0]) {
            case "-pl":
            case "--project-list":
                return new ProjectListCommand();

            case "-tl":
            case "--task-list":
                return new TaskListCommand();

            default:
                return new HelpCommand();
        }
    }
}
