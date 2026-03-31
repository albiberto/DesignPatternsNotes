namespace DesignPatternsNotes.Behavioral.Command;

public class Invoker
{
    private ICommand? _onStart;
    private ICommand? _onFinish;
    
    public ICommand? SetOnStart(ICommand command) => _onStart = command;
    public ICommand? SetOnFinish(ICommand command) => _onFinish = command;

    public string DoSomethingImportant() =>
        $"""
            Invoker: Does anybody want something done before I begin?
            {(_onStart != null ? _onStart.Execute() : "")}
            Invoker: ...doing something really important...
            Invoker: Does anybody want something done after I finish?
            {(_onFinish != null ? _onFinish.Execute() : "")}
        """;
}