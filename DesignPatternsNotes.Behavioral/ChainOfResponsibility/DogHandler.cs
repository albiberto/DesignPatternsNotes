namespace DesignPatternsNotes.Behavioral.ChainOfResponsibility;

public class DogHandler : AbstractHandler
{
    public override object? Handle(object request) =>
        request as string == "Nut" 
            ? $"Dog: I'll eat the {request}." 
            : base.Handle(request);
}