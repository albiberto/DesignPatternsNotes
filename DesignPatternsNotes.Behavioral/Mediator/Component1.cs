namespace DesignPatternsNotes.Behavioral.Mediator;

public class Component1(IMediator mediator)
{
    public  void DoA()
    {
        Console.WriteLine("Component 1 does A.");

        mediator.Notify(this, "A");
    }

    public void DoB()
    {
        Console.WriteLine("Component 1 does B.");

        mediator.Notify(this, "B");
    }
}