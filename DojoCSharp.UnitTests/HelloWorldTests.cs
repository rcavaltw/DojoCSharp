namespace DojoCSharp.UnitTests;

public class HelloWorldTests
{
    [Fact]
    public void HelloWorldShouldSayHello()
    {
        HelloWorld.Hello().Should().Be("Hello, World!");
    }
}