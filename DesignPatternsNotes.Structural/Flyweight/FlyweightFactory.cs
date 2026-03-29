namespace DesignPatternsNotes.Structural.Flyweight;

public class FlyweightFactory
{
    private List<(Flyweight, string)> flyweights = [];

    public FlyweightFactory(params Car[] args)
    {
        foreach (var car in args)
        {
            flyweights.Add((new(car), GetKey(car)));
        }
    }

    private static string GetKey(Car key)
    {
        List<string> elements =
        [
            key.Model,
            key.Color,
            key.Company,
            key.Number,
            key.Owner
        ];

        elements.Sort();

        return string.Join("_", elements);
    }
}