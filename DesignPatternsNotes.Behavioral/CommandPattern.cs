using DesignPatternsNotes.Behavioral.Command;
using DesignPatternsNotes.Core;

namespace DesignPatternsNotes.Behavioral;

public class CommandPattern(IDisplay display) : IBehavioral
{
    public string Name { get; } = "Command";

    public string Description { get; } = """
                                         Command is a behavioral design pattern that turns a request into a stand-alone object that contains all information about the request.
                                         This transformation lets you pass requests as a method arguments, delay or queue a request's execution, and support undoable operations.
                                         """;

    public string Problem { get; } = """
                                     Imagine that you're working on a new text-editor app.
                                     Your current task is to create a toolbar with a brunch of buttons for various operations of the editor.
                                     You created a very neat Button class that can be used for buttons on the toolbar, as well as for generic buttons in various dialogs.
                                     
                                     While all of these buttons look similar, they're all supposed to do different things. 
                                     Where would you put hte code for the various click handlers of the buttons?
                                     """;

    public string Solution { get; } = """
                                      Good software design is often based on the principle of separation of concerns, which usually returns in breaking app into layers.
                                      The Command pattern suggests that GUI objects shouldn't know anything about the business logic of the app.
                                      The Command pattern suggests that GUI objects shouldn’t send these requests directly. Instead, you should extract all of the request details, such as the object being called, the name of the method and the list of arguments into a separate command class with a single method that triggers this request.
                                      """;

    public string Applicability { get; } = "Use the Command pattern when you want to parameterize objects with operations.";

    public void Run()
    {
        display.WriteSpacedLine("""
                                var invoker = new Invoker();
                                invoker.SetOnStart(new SimpleCommand("Say Hi!"));
                                var receiver = new Receiver();
                                invoker.SetOnFinish(new ComplexCommand(receiver, "Send email", "Save report"));
                                
                                invoker.DoSomethingImportant();
                                """);
        
        var invoker = new Invoker();
        invoker.SetOnStart(new SimpleCommand("Say Hi!"));
        var receiver = new Receiver();
        invoker.SetOnFinish(new ComplexCommand(receiver, "Send email", "Save report"));
        
        var result = invoker.DoSomethingImportant();
        
        display.WriteSpacedLine(result);
    }
}