namespace DesignPatternsNotes.Creational.Singleton;

public sealed class Singleton
{
    private static Singleton? _instance;

    private Singleton()
    {
    }

    public static Singleton GetInstance() => _instance ??= new();
}