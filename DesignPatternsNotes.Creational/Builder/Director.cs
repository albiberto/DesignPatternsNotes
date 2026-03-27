namespace DesignPatternsNotes.Creational.Builder;

public class Director(IBuilder builder)
{
    public void BuildMinimalProduct() =>
        builder.BuildPartA();

    public void BuildFullFeatureProduct()
    {
        builder.BuildPartA();
        builder.BuildPartB();
        builder.BuildPartC();
    }
}