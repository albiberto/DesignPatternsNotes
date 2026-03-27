using DesignPatternsNotes.Core;

namespace DesignPatternsNotes;

public class Display : IDisplay
{
    public void WriteLine(string? value) => Console.WriteLine(value);
    
    public void WriteSpacedLine(string? value = null)
    {
        Console.WriteLine(value);
        Console.WriteLine();
    }
}