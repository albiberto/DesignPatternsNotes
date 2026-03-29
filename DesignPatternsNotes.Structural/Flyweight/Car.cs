namespace DesignPatternsNotes.Structural.Flyweight;

public record Car
{
    public string Owner { get; init; }
    public string Number { get; init; }
    public string Company { get; init; }
    public string Model { get; init; }
    public string Color { get; init; }
}