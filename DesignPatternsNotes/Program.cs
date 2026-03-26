using DesignPatternsNotes;
using DesignPatternsNotes.Behavioral;
using DesignPatternsNotes.Core;
using DesignPatternsNotes.Creational;
using DesignPatternsNotes.Structural;
using Microsoft.Extensions.DependencyInjection;
using Console = System.Console;

var services = new ServiceCollection();

services.AddPatternsFromAssemblyOf<ICreational>();
services.AddPatternsFromAssemblyOf<IBehavioral>();
services.AddPatternsFromAssemblyOf<IStructural>();
services.AddSingleton<IDisplay, Display>();

// 1. PRIMA costruiamo il ServiceProvider
var provider = services.BuildServiceProvider();

// 2. POI passiamo il provider per costruire il menu
var menu = provider.BuildExamplesMap(); 

while (true)
{
    Console.Clear();
    Console.WriteLine("=== MY DESIGN PATTERNS NOTES ===");

    var categories = menu.Keys.ToList();
    if (categories.Count == 0)
    {
        Console.WriteLine("Nessun pattern trovato. Assicurati di aver referenziato i progetti!");
        break;
    }

    Console.WriteLine("0. Exit");
    for (var i = 0; i < categories.Count; i++) Console.WriteLine($"{i + 1}. {categories[i]} Patterns");
    Console.WriteLine("Scegli una categoria: ");

    if (ReadLine(categories.Count, out var categoryIndex)) continue;

    var selectedCategory = categories[categoryIndex - 1];
    var patterns = menu[selectedCategory];

    Console.WriteLine($"\n--- {selectedCategory} Patterns ---");
    for (var i = 0; i < patterns.Count; i++) Console.WriteLine($"{i + 1}. {patterns[i].Name}");
    Console.Write("Scegli il pattern da studiare: ");

    if (ReadLine(patterns.Count, out var exampleIndex)) continue;

    var selectedExample = patterns[exampleIndex - 1];
    
    Console.Clear();
    Console.WriteLine("==================================================");
    Console.WriteLine($" PATTERN: {selectedExample.Name.ToUpper()} ({selectedCategory})");
    Console.WriteLine("==================================================");

    Console.ForegroundColor = ConsoleColor.Gray;
    Console.WriteLine("\n[DESCRIPTION]");
    Console.ResetColor();
    Console.WriteLine(selectedExample.Description);
    
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\n[PROBLEM]");
    Console.ResetColor();
    Console.WriteLine(selectedExample.Problem);

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("\n[SOLUTION]");
    Console.ResetColor();
    Console.WriteLine(selectedExample.Solution);
    
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.WriteLine("\n[APPLICABILITY]");
    Console.ResetColor();
    // 3. Corretto il bug: prima qui c'era scritto selectedExample.Solution
    Console.WriteLine(selectedExample.Applicability); 
    Console.WriteLine("--------------------------------------------------");

    using var scope = provider.CreateScope();
    
    // 4. Recuperiamo il pattern dalla DI chiedendo tutti gli IPattern e filtrando per chiave
    var patternInstance = scope.ServiceProvider
        .GetServices<IPattern>()
        .First(p => p.Key == (selectedCategory, selectedExample.Name));

    patternInstance.Run();

    Console.WriteLine("\nPremi Invio per tornare al menu principale...");
    Console.ReadLine();
}

return;

bool ReadLine(int count, out int index)
{
    var result = int.TryParse(Console.ReadLine(), out index);

    if (result && index >= 0 && index <= count) return false;

    if (index == 0) Environment.Exit(0); // Permette di uscire premendo 0

    Console.WriteLine("Scelta non valida. Riprova.");
    Console.WriteLine("\nPremi Invio per continuare...");
    Console.ReadLine();

    return true;
}