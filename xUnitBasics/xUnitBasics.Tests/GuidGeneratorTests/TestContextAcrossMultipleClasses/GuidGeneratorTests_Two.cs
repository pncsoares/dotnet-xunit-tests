using Xunit;
using Xunit.Abstractions;

namespace xUnitBasics.Tests.GuidGeneratorTests.TestContextAcrossMultipleClasses;

[Collection("GuidGeneratorDefinition")]
public class GuidGeneratorTests_Two
{
    private readonly GuidGenerator _sut;
    private readonly ITestOutputHelper _output;

    public GuidGeneratorTests_Two(ITestOutputHelper output, GuidGenerator sut)
    {
        _output = output;
        _sut = sut;
    }
    
    [Fact]
    public void GuidTest_One()
    {
        var guid = _sut.RandomGuid;
        _output.WriteLine($"The guid was: {guid}");
    }
    
    [Fact]
    public void GuidTest_Two()
    {
        var guid = _sut.RandomGuid;
        _output.WriteLine($"The guid was: {guid}");
    }
}