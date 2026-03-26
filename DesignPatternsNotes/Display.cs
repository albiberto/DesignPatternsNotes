using DesignPatternsNotes.Core;

namespace DesignPatternsNotes;

public class Display : IDisplay
{
    public void WriteLine(string? value) => Console.WriteLine(value);
}