namespace DesignPatternsNotes.Behavioral;

public class IteratorPattern : IBehavioral
{
    public string Name { get; } = "Iterator";
    public string Description { get; } = "Iterator is a behavioral design pattern that lets you traverse elements of a collection without exposing its underlying representation.";
    public string Problem { get; } = "Collections are one of the most used data types in programming. Nonetheless, a collection is just a container for a group of objects.";            
    public string Solution { get; } = "The main idea of the Iterator pattern is to extract the traversal behavior of a collection into a separate object called an iterator. This iterator object can be used to traverse the collection without exposing its underlying representation.";
    public string Applicability { get; } = "Use the Iterator pattern when your collection has a complex data structure under the hood, but you want to hide its complexity from clients (either for convenience or security reasons).";
    
    public void Run()
    {
        throw new NotImplementedException();
    }
}