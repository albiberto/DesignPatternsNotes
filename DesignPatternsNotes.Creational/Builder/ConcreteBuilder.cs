namespace DesignPatternsNotes.Creational.Builder;

public class ConcreteBuilder : IBuilder
{
    private Product _product = null!;
 
    public ConcreteBuilder() => Reset();
    
    public void Reset() => _product = new();
    
    public void BuildPartA() => _product.Add("PartA");

    public void BuildPartB() => _product.Add("PartB");

    public void BuildPartC() => _product.Add("PartC");
    
    public Product GetProduct()
    {
        var result = _product;
        Reset();
        return result;
    }
}