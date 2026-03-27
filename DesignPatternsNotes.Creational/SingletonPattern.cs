using DesignPatternsNotes.Core;
using DesignPatternsNotes.Creational.Abstract;
using SingletonClass =  DesignPatternsNotes.Creational.Singleton.Singleton;

namespace DesignPatternsNotes.Creational;

public class SingletonPattern(IDisplay display) : ICreational
{
    public string Name { get; } = "Singleton";

    public string Description { get; } = """
                                         Singleton is a creational design pattern that lets you ensure that a class has only one instance, 
                                         while providing a global access point to this instance.
                                         """;

    public string Problem { get; } = """
                                     The Singleton pattern solves two problems at the same time, violating the Single Responsability Principle:
                                       1. Ensure that a class has a single instance.
                                       2. Provide a global access point to that instance.
                                     """;

    public string Solution { get; } = """
                                      All implementations of the Singleton have these two steps in common:
                                           1. Make the class constructor private, to prevent other objects from the `new` operator with the Singleton class.
                                           2. Create a static creation method that acts as a constructor. 
                                              Under the hood, this method calls the private constructor to creare an object and saves it in a static field. 
                                              All following calls to this method return the cached object. 
                                      """;

    public string Applicability { get; } = "Use the Singleton pattern when a class in your program should have just a single instance available to all clients.";

    public void Run()
    {
        var s1 = SingletonClass.GetInstance();
        var s2 = SingletonClass.GetInstance();
        
        display.WriteSpacedLine("""
                          var s1 = SingletonClass.GetInstance();
                          var s2 = SingletonClass.GetInstance();
                          """);

        display.WriteSpacedLine("s1 == s2;");
        
        display.WriteLine(s1 == s2 
            ? "Singleton works, both variables contain the same instance." 
            : "Singleton failed, variables contain different instances.");
    }
}