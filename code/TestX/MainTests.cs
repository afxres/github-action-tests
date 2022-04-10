namespace TestX;

using Xunit;
using Xunit.Abstractions;

public class MainTests
{
    private readonly ITestOutputHelper output;

    public MainTests(ITestOutputHelper output)
    {
        this.output = output;
    }

    [Fact]
    public void HelloWorld()
    {
        output.WriteLine("Hello, world!");
    }
}
