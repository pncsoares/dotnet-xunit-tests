using Xunit;
using Xunit.Abstractions;

namespace xUnitBasics.Tests.GuidGeneratorTests.TestContextWithinTheSameClass;

public class GuidGeneratorTests_SameInstance : IClassFixture<GuidGenerator>
{
    private readonly GuidGenerator _sut;
    private readonly ITestOutputHelper _output;

    public GuidGeneratorTests_SameInstance(ITestOutputHelper output, GuidGenerator sut)
    {
        _output = output;
        _sut = sut;
    }
    
    // the guid generated will be the same within the two methods
    // run the tests and confirm the output 👇
    
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