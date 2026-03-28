namespace DesignPatternsNotes.Structural.Adapter;

public class Adapter(Adaptee adaptee) : ITarget
{
    public string GetRequest() => $"This is '{adaptee.GetSpecificRequest()}'";
}