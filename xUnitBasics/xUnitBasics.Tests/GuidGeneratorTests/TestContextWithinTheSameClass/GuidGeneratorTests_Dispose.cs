using System;
using Xunit;
using Xunit.Abstractions;

namespace xUnitBasics.Tests.GuidGeneratorTests.TestContextWithinTheSameClass;

public class GuidGeneratorTests_Dispose : IClassFixture<GuidGenerator>, IDisposable
{
    private readonly GuidGenerator _sut;
    private readonly ITestOutputHelper _output;

    public GuidGeneratorTests_Dispose(ITestOutputHelper output, GuidGenerator sut)
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

    // after all tests are run, the class will be disposed
    // check the output 👇
    
    public void Dispose()
    {
        _output.WriteLine($"The class was disposed.");
    }
}