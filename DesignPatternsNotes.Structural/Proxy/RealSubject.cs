namespace DesignPatternsNotes.Structural.Proxy;

public class RealSubject : ISubject
{
    public string Request() => "RealSubject: Handling Request.";
}