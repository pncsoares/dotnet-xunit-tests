using Xunit;
using xUnitBasics.Tests.CalculatorTests.ClassData;

namespace xUnitBasics.Tests.CalculatorTests;

public class CalculatorTests_ClassData
{
    private readonly Calculator _sut;

    public CalculatorTests_ClassData()
    {
        _sut = new Calculator();
    }
    
    [Theory]
    [ClassData(typeof(AdditionTestData))]
    public void Theory_MemberData_AddManyNumbers_ShouldReturnTheirAddition(decimal expected, params decimal[] valuesToAdd)
    {
        foreach (var value in valuesToAdd)
        {
            _sut.Add(value);    
        }
        
        Assert.Equal(expected, _sut.Value);
    }
    
    [Theory]
    [ClassData(typeof(SubtractionTestData))]
    public void Theory_MemberData_SubtractManyNumbers_ShouldReturnTheirSubtraction(decimal expected, params decimal[] valuesToSubtract)
    {
        foreach (var value in valuesToSubtract)
        {
            _sut.Subtract(value);    
        }
        
        Assert.Equal(expected, _sut.Value);
    }
    
    [Theory]
    [ClassData(typeof(MultiplicationTestData))]
    public void Theory_MemberData_MultiplyManyNumbers_ShouldReturnTheirMultiplication(decimal expected, params decimal[] valuesToMultiply)
    {
        foreach (var value in valuesToMultiply)
        {
            _sut.Multiply(value);    
        }
        
        Assert.Equal(expected, _sut.Value);
    }
    
    [Theory]
    [ClassData(typeof(DivisionTestData))]
    public void Theory_MemberData_DivideManyNumbers_ShouldReturnTheirDivision(decimal expected, params decimal[] valuesToDivide)
    {
        foreach (var value in valuesToDivide)
        {
            _sut.Divide(value);    
        }
        
        Assert.Equal(expected, _sut.Value);
    }
}