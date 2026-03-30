namespace DesignPatternsNotes.Behavioral.ChainOfResponsibility;

class MonkeyHandler : AbstractHandler
{
    public override object? Handle(object request) =>
        request as string == "Banana" 
            ? $"Monkey: I'll eat the {request}." 
            : base.Handle(request);
}