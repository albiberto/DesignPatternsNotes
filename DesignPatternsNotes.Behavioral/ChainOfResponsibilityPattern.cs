using DesignPatternsNotes.Behavioral.ChainOfResponsibility;
using DesignPatternsNotes.Core;

namespace DesignPatternsNotes.Behavioral;

public class ChainOfResponsibilityPattern(IDisplay display) : IBehavioral
{
    public string Name { get; } = "Chain of Responsibility";
    public string Description { get; } = "Chain of Responsibility is behavioral design pattern that allows passing request along the chain of potential handlers until one handles the request.";

    public string Problem { get; } = """
                                     Imagine that you're working on an online ordering system.
                                     You want to restrict access to the system so only authenticated users can create orders.
                                     Also, users who have administration permissions must have full access to all orders.

                                     After a bit of planning, you realized that these checks must be performed sequentially.
                                     The application can attempt to authenticate a user to the system whenever it receives a request that contains the user's credentials.
                                     However, if those credentials aren't correct and authentication fails, there's no reason to proceed with any other checks.
                                     """;

    public string Solution { get; } = """
                                      Like many other behavioral design patterns, the Chain of Responsibility relies on transforming particular behaviors into stand-alone objects called handlers.
                                      In our case, each check should be extracted to its own class with a single method that performs the check.

                                      The pattern suggests that you link these handlers into a chian.
                                      Each linked handler has a field for storing a reference to the next handler in the chain.
                                      In addition to processing a request, handlers pass the request further along the chain.
                                      The request travels along the chain until all handlers have had a chance to process it.  
                                      """;

    public string Applicability { get; } = "Use the Chain of Responsibility patter when your program is expected to process different kinds of requests and their sequences are unknown beforehand.";

    public void Run()
    {
        List<string> foods = ["Nut", "Banana", "Cup of coffee"];
        
        var monkey = new MonkeyHandler();
        var squirrel = new SquirrelHandler();
        var dog = new DogHandler();
        
        monkey.SetNext(squirrel).SetNext(dog);
        
        display.WriteSpacedLine("""
                                List<string> foods = ["Nut", "Banana", "Cup of coffee"];
                                
                                var monkey = new MonkeyHandler();
                                var squirrel = new SquirrelHandler();
                                var dog = new DogHandler();
                                
                                monkey.SetNext(squirrel).SetNext(dog);
                                """);
        
        display.WriteSpacedLine("Chain: Monkey > Squirrel > Dog");

        display.WriteSpacedLine("""
                                foreach (var food in foods)
                                {
                                    var result = monkey.Handle(food);
                                    display.WriteLine(result is not null ? $"Client: {result}" : $"Client: {food} was left untouched.");
                                }
                                """);
        
        foreach (var food in foods)
        {
            var result = monkey.Handle(food);
            display.WriteLine(result is not null ? $"Client: {result}" : $"Client: {food} was left untouched.");
        }
    }
}