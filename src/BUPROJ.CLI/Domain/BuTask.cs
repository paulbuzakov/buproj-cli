namespace BUPROJ.CLI.Domain;

internal class BuTask {
    public int Layer { get; private set; }
    public int LineIndex { get; private set; }
    public string Title { get; private set; }

    protected BuTask(int layer, int lineIndex, string title)
    {
        Layer = layer;
        LineIndex = lineIndex;
        Title = title;
    }

    public static BuTask? CreateFromFileLine(int lineIndex, string fileLine) {
        if (!fileLine.StartsWith('-')) {
            return null;
        }

        var layer = fileLine.IndexOf(' ');
        return new BuTask(layer, lineIndex, fileLine.Substring(layer));
    }

    public override string ToString()
    {
        return String.Format($"[{LineIndex}-{Layer}] {Title}");
    }
}