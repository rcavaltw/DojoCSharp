namespace DojoCSharp.UnitTests;

public class RomanNumeralConverterTest
{
    [Fact]
    public void HelloWorldShouldSayHello()
    {
        RomanNumeralConverter.toRoman(1).Should().Be("I");
    }
}