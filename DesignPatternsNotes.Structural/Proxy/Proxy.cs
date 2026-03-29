namespace DesignPatternsNotes.Structural.Proxy;

public class Proxy(ISubject subject) : ISubject
{
    public string Request() =>
        $"""
         {subject.Request()}
         {Caching()}
         {Logging()}
         {Authenticating()}
         """;

    private static string Caching() => "Proxy: Caching.";
    private static string Logging() => "Proxy: Logging.";
    private static string Authenticating() =>  "Proxy Authenticating.";
}