namespace DesignPatternsNotes.Behavioral.Mediator;

public class ConcreateMediator(Component1 component1, Component2 component2) : IMediator
{
    public void Notify(object sender, string ev)
    {
        if (ev == "A")
        {
            Console.WriteLine("Mediator reacts on A and triggers following operations:");
            component2.DoC();
        }

        if (ev == "D")
        {
            Console.WriteLine("Mediator reacts on D and triggers following operations:");
            component1.DoB();
            component2.DoC();
        }
    }
}