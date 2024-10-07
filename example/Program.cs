namespace Example;

internal static class Program
{
    public static void Main()
    {
        var jsonExampleData = File.ReadAllText("/home/notation/projects/dax/kmd-smile-topology/example/data/example.json");
        Console.WriteLine(jsonExampleData);
    }
}
