using Console = System.Console;

namespace DesignPatternsNotes.Creational.Singleton;

public class SingletonPattern : ICreational
{
    public string Name { get; }  = "Singleton";
    public string Description { get; }  = "Singleton";
    public string Problem { get; }   = "Singleton";
    public string Solution { get; }  = "Singleton";

    public void Run()
    {
        Console.WriteLine("\n[Esecuzione Codice Pratico: Singleton]");
        Console.WriteLine("Qui in futuro scriveremo il codice C# per dimostrare il pattern...");
        // Esempio:
        // var instance1 = Singleton.GetInstance();
        // var instance2 = Singleton.GetInstance();
        // Console.WriteLine($"Sono la stessa istanza? {instance1 == instance2}");
    }
}