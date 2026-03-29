namespace DesignPatternsNotes.Structural.Flyweight;

public class Flyweight(Car sharedState)
{
    public string Operation(Car uniqueState) => $"Flyweight: Displaying shared ({sharedState}) and unique ({uniqueState}) state.";
}