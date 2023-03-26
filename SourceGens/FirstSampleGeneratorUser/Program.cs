using SourceGeneratorSample;

var mc = new MyClass() { Hoge = 10, Bar = "tako" };
Console.WriteLine(mc);

[GenerateToString]
public partial class MyClass
{
    public int Hoge { get; set; }
    public string? Bar { get; set; }
}

