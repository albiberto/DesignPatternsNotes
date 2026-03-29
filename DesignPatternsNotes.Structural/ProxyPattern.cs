using DesignPatternsNotes.Core;
using DesignPatternsNotes.Structural.Proxy;
using ProxyClass = DesignPatternsNotes.Structural.Proxy.Proxy;

namespace DesignPatternsNotes.Structural;

public class ProxyPattern(IDisplay display) : IStructural
{
    public string Name { get; } =  "Proxy";
    public string Description { get; } = "Proxy is a structural design pttern that provides an object that acts as a substitute for a real service object ";

    public string Problem { get; } = """
                                     Why would you want to control access to an object?
                                     Here is an example: you have a massive object that consumes a vest amount of system resources.
                                     You need it from time to time but not always.
                                     """;

    public string Solution { get; } = """
                                      The proxy pattern suggests that you create a new proxy class with the same interface as an original service object.
                                      Then you update your app so that is passed the proxy object to all of the original objects's client.
                                      """;

    public string Applicability { get; } = """
                                           - Lazy initialization (virtual proxy). This is when you have a heavyweight service object that wastes system resources by being always up, even though you only need it from time to time.
                                           - Access control (protection proxy). This is when you want only specific clients to be able to use the service object; for instance, when your objects are crucial parts of an operating system and clients are various launched applications (including malicious ones).
                                           - Local execution of a remote service (remote proxy). This is when the service object is located on a remote server;
                                           - Logging requests (logging proxy). This is when you want to keep a history of requests to the service object;
                                           - Caching request results (caching proxy). This is when you need to cache results of client requests and manage the life cycle of this cache, especially if results are quite large.
                                           """;
    public void Run()
    {
        display.WriteSpacedLine("""
                                 var subject = new RealSubject();
                                 subject.Request();
                                 """);
    
        var subject = new RealSubject();
        display.WriteSpacedLine(subject.Request());

        display.WriteSpacedLine("""
                                 var proxy = new ProxyClass(subject);
                                 proxy.Request();
                                 """);
        
        var proxy = new ProxyClass(subject);
        display.WriteSpacedLine(proxy.Request());
    }
}