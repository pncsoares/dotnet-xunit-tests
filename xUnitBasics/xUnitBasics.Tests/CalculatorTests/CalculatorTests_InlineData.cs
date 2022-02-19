using System;
using Xunit;

namespace xUnitBasics.Tests.CalculatorTests;

public class CalculatorTests_InlineData
{
    private readonly Calculator _sut;
    
    public CalculatorTests_InlineData()
    {
        _sut = new Calculator();
    }
    
    [Theory]
    [InlineData(0, 0, 0)]
    [InlineData(1, 1, 0)]
    [InlineData(1, 0, 1)]
    [InlineData(50, 51, -1)]
    [InlineData(13, 5, 8)]
    public void Theory_InlineData_AddTwoNumbers_ShouldReturnTheirSum(decimal expected, decimal firstToAdd, decimal secondToAdd)
    {
        _sut.Add(firstToAdd);
        _sut.Add(secondToAdd);
        
        Assert.Equal(expected, _sut.Value);
    }
    
    [Theory]
    [InlineData(0, 0, 0)]
    [InlineData(-1, 1, 0)]
    [InlineData(-1, 0, 1)]
    [InlineData(-50, 51, -1)]
    [InlineData(-21, 13, 8)]
    public void Theory_InlineData_AddTwoNumbers_ShouldReturnTheirSubtraction(decimal expected, decimal firstToSubtract, decimal secondToSubtract)
    {
        _sut.Subtract(firstToSubtract);
        _sut.Subtract(secondToSubtract);
        
        Assert.Equal(expected, _sut.Value);
    }
    
    [Theory]
    [InlineData(0, 0, 0)]
    [InlineData(0, 1, 0)]
    [InlineData(0, 0, 1)]
    [InlineData(-51, 51, -1)]
    [InlineData(6, 3, 2)]
    public void Theory_InlineData_MultiplyTwoNumbers_ShouldReturnTheirSum(decimal expected, decimal firstToMultiply, decimal secondToMultiply)
    {
        _sut.Multiply(firstToMultiply);
        _sut.Multiply(secondToMultiply);
        
        Assert.Equal(expected, _sut.Value);
    }
    
    [Theory]
    [InlineData(-51, 51, -1)]
    [InlineData(0.625, 5, 8)]
    [InlineData(1.6, 8, 5)]
    public void Theory_InlineData_DivideTwoNumbers_ShouldReturnTheirSum(decimal expected, decimal firstToDivide, decimal secondToDivide)
    {
        _sut.Divide(firstToDivide);
        _sut.Divide(secondToDivide);
        
        Assert.Equal(expected, _sut.Value);
    }
}