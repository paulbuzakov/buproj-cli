using BUPROJ.CLI.Domain;

namespace BUPROJ.CLI.Commands.Impls;

internal class TaskListCommand : ICommand
{
    public void Execute(string[] args)
    {
        if (args.Length <= 1) {
            throw new Exception("You need select *.buproj file.");
        }

        foreach(var task in ParseFile(args[1])) {
            Console.WriteLine(task);
        }
    }

    private IEnumerable<BuTask> ParseFile(string path) {
        var lines = File.ReadLines(path).ToArray();

        var count = lines.Count();

        for (int i = 0; i < count; i++) {
            var cur = BuTask.CreateFromFileLine(i, lines[i]);
            if (cur == null) {
                continue;
            }

            var next = BuTask.CreateFromFileLine(i + 1, lines[i + 1]);
            if (next == null || i + 1 >= count) {
                yield return cur;
                continue;
            }

            if(cur.Layer >= next.Layer) {
                yield return cur;
                continue;
            }
        }
    }
}
