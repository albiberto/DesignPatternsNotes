namespace DesignPatternsNotes.Behavioral.Mediator;

public class Component2(IMediator mediator)
{
    public  void DoC()
    {
        Console.WriteLine("Component 2 does C.");

        mediator.Notify(this, "C");
    }

    public void DoD()
    {
        Console.WriteLine("Component 2 does D.");

        mediator.Notify(this, "B");
    }
}