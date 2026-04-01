namespace DesignPatternsNotes.Behavioral.Mediator;

public interface IMediator
{
    void Notify(object sender, string ev);   
}