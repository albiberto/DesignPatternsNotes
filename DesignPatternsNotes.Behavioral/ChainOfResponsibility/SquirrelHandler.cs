namespace DesignPatternsNotes.Behavioral.ChainOfResponsibility;

public class SquirrelHandler : AbstractHandler
{
    public override object? Handle(object request) =>
        request as string == "Nut" 
            ? $"Squirrel: I'll eat the {request}." 
            : base.Handle(request);
}