namespace DesignPatternsNotes.Core;

public interface IDisplay
{
    public void WriteLine(string? value = null);

    public void WriteSpacedLine(string? value = null);
}