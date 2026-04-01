using DesignPatternsNotes.Behavioral.Mediator;

namespace DesignPatternsNotes.Behavioral;

public class MediatorPattern : IBehavioral
{
    public string Name { get; } = "Mediator";
    public string Description { get; } = "Mediator is a behavioral design pattern that reduces coupling between components of a program by making them communicate indirectly, through a special mediator object";

    public string Problem { get; } = """
                                     Say you have a dialog for creating and editing customer profiles. It consists of various from controls such as text fields, checkboxes, button, etc.
                                     Some of the elements may interact with others.
                                     For instance, selecting the "I have a dog" checkbox may reveal a hidden text field for entering the dog's name.
                                     Another example is the submit button that has to validate value of all fields before saving data.
                                     By having this logic implemented directly inside the code of the form elements you make these elements classes much harder to reuse in other forms of the app.
                                     """;

    public string Solution { get; } = """
                                      The Mediator pattern suggests that you should cease all direct communication between components which you want to make independent of each other. 
                                      Instead, these components must collaborate indirectly, by calling a special mediator object that redirects the calls to appropriate components.
                                      As a result, the components depend only on a single mediator class instead of being coupled to dozens of their colleagues. 
                                      """;

    public string Applicability { get; } = " Use the Mediator pattern when it’s hard to change some of the classes because they are tightly coupled to a bunch of other classes.";

    public void Run()
    {
        var madiator = new ConcreateMediator(null, null);
        var component1 = new Component1(null);
        var component2 = new Component2(null);
    }
}