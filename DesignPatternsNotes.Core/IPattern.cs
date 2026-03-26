namespace DesignPatternsNotes.Core;

public interface IPattern
{
    public string Category { get; }
    public string Name { get; }
    public string Description { get; }
    public string Problem { get; }
    public string Solution { get; }
    public string Applicability { get; }
    
    public (string Category, string Name) Key => (Category, Name);
    
    void Run(); 
}