using Xunit;
using Xunit.Abstractions;

namespace xUnitBasics.Tests.GuidGeneratorTests.TestContextWithinTheSameClass;

public class GuidGeneratorTests_IndividualInstances
{
    private readonly GuidGenerator _sut;
    private readonly ITestOutputHelper _output;

    public GuidGeneratorTests_IndividualInstances(ITestOutputHelper output)
    {
        _output = output;
        _sut = new GuidGenerator();
    }

    // the guid generated will be different
    // because the method _One uses an instance and the method _Two uses another instance
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