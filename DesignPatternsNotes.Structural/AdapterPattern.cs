using DesignPatternsNotes.Core;
using DesignPatternsNotes.Structural.Adapter;
using AdapterClass = DesignPatternsNotes.Structural.Adapter.Adapter;

namespace DesignPatternsNotes.Structural;

public class AdapterPattern(IDisplay display) : IStructural
{
    public string Name { get; } = "Adapter";
    public string Description { get; } = "Adapter is a structural design pattern that allows objects with incompatible interfaces to work together. It acts as a bridge between two incompatible interfaces to collaborate";
    public string Problem { get; } = """
                                     Imagine that you're creating a stock market monitoring app.
                                     The app downloads the stock data from multiple sources in XML format and then displays nice-looking charts and diagrams for the user.
                                     
                                     At some point, you decide to improve the app by integrating a smart 3rd-party analytics library.
                                     But there's a catch: the analytics library only works with data in JSON format. 
                                     """;
    public string Solution { get; } = """
                                      You can create ad adapter. This is a special object that converts the interface of one object so that another object can understand it.
                                      An adapter wraps one og the objects to hide the complexity of conversion happening behind the scenes. 
                                      The wrapper object isn't even aware of the adapter.
                                      """;

    public string Applicability { get; } = "Use the Adapter class when you want to use some existing class, but its interface isn't compatible with the rest of your code.";
    
    public void Run()
    {
        display.WriteSpacedLine("""
                                var adaptee = new Adaptee();
                                var target = new AdapterClass(adaptee);
                                """);
        var adaptee = new Adaptee();
        var target = new AdapterClass(adaptee);

        display.WriteLine("Adaptee interface is incompatible with the client.");
        display.WriteLine("But with adapter client can call it's method.");

        display.WriteLine(target.GetRequest());
    }
}