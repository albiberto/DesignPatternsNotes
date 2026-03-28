namespace DesignPatternsNotes.Creational.FactoryMethod;

public abstract class CreatorBase
{
    protected abstract IProduct FactoryMethod(); 
    
    public string SomeOperation()
    {
        var product = FactoryMethod();
        return $"Creator: The same creator's code has just worked with {product.Operation()}";
    }
}