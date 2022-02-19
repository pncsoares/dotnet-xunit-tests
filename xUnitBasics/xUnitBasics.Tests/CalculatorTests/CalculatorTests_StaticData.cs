using System;
using Xunit;

namespace xUnitBasics.Tests.CalculatorTests;

public class CalculatorTests_StaticData
{
    private readonly Calculator _sut;

    public CalculatorTests_StaticData()
    {
        _sut = new Calculator();
    }
    
    // [Fact(Skip = "This tests is obsolete")] // you can skip a test using this
    // public void Fact_AddTwoNumbers_ShouldReturnTwenty()
    // {
    //     _sut.Add(10);
    //     _sut.Add(10);
    //     
    //     Assert.Equal(20, _sut.Value);
    // }
    
    [Fact]
    public void Fact_AddTwoNumbers_ShouldReturnZero()
    {
        _sut.Add(0);
        _sut.Add(0);
        
        Assert.Equal(0, _sut.Value);
    }
    
    [Fact]
    public void Fact_AddTwoNumbers_ShouldReturnTwo()
    {
        _sut.Add(1);
        _sut.Add(1);
        
        Assert.Equal(2, _sut.Value);
    }
    
    [Fact]
    public void Fact_SubtractTwoNumbers_ShouldReturnNegativeTwo()
    {
        _sut.Subtract(1);
        _sut.Subtract(1);
        
        Assert.Equal(-2, _sut.Value);
    }
    
    [Fact]
    public void Fact_MultiplyTwoNumbers_ShouldReturnZero()
    {
        _sut.Multiply(10);
        _sut.Multiply(0);
        
        Assert.Equal(0, _sut.Value);
    }
    
    [Fact]
    public void Fact_MultiplyTwoNumbers_ShouldReturnOne()
    {
        _sut.Multiply(1);
        _sut.Multiply(1);
        
        Assert.Equal(1, _sut.Value);
    }
    
    [Fact]
    public void Fact_MultiplyTwoNumbers_ShouldReturnFour()
    {
        _sut.Multiply(2);
        _sut.Multiply(2);
        
        Assert.Equal(4, _sut.Value);
    }
    
    [Fact]
    public void Fact_DivideTwoNumbers_ShouldThrow_DivideByZeroException()
    {
        _sut.Divide(1);
        
        Action act = () => _sut.Divide(0); 
        
        Assert.Throws<DivideByZeroException>(act);
    }
    
    [Fact]
    public void Fact_DivideTwoNumbers_ShouldReturnOne()
    {
        _sut.Divide(1);
        _sut.Divide(1);
        
        Assert.Equal(1, _sut.Value);
    }
    
    [Fact]
    public void Fact_DivideTwoNumbers_ShouldReturnTen()
    {
        _sut.Divide(20);
        _sut.Divide(2);
        
        Assert.Equal(10, _sut.Value);
    }
}