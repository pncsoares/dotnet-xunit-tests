using System.Collections.Generic;
using Xunit;

namespace xUnitBasics.Tests.CalculatorTests;

public class CalculatorTests_MemberData
{
    private readonly Calculator _sut;

    public CalculatorTests_MemberData()
    {
        _sut = new Calculator();
    }

    private static IEnumerable<object[]> AdditionTestData()
    {
        yield return new object[] { 15, new decimal[] { 10, 5 }};
        yield return new object[] { 15, new decimal[] { 5, 5, 5 }};
        yield return new object[] { -10, new decimal[] { -30, 20 }};
    }

    [Theory]
    [MemberData(nameof(AdditionTestData))]
    public void Theory_MemberData_AddManyNumbers_ShouldReturnTheirSum(decimal expected, params decimal[] valuesToAdd)
    {
        foreach (var value in valuesToAdd)
        {
            _sut.Add(value);
        }

        Assert.Equal(expected, _sut.Value);
    }

    private static IEnumerable<object[]> SubtractionTestData()
    {
        yield return new object[] { 0, new decimal[] { 0, 0 }};
        yield return new object[] { -1, new decimal[] { 1, 0 }};
        yield return new object[] { -1, new decimal[] { 0, 1 }};
        yield return new object[] { -50, new decimal[] { 51, -1 }};
        yield return new object[] { -21, new decimal[] { 13, 8 }};
    }

    [Theory]
    [MemberData(nameof(SubtractionTestData))]
    public void Theory_MemberData_SubtractManyNumbers_ShouldReturnTheirSubtraction(decimal expected,
        params decimal[] valuesToSubtract)
    {
        foreach (var value in valuesToSubtract)
        {
            _sut.Subtract(value);
        }

        Assert.Equal(expected, _sut.Value);
    }

    private static IEnumerable<object[]> MultiplicationTestData()
    {
        yield return new object[] { 0, new decimal[] { 0, 0 }};
        yield return new object[] { 0, new decimal[] { 1, 0 }};
        yield return new object[] { 0, new decimal[] { 0, 1 }};
        yield return new object[] { -51, new decimal[] { 51, -1 }};
        yield return new object[] { 6, new decimal[] { 3, 2 }};
    }

    [Theory]
    [MemberData(nameof(MultiplicationTestData))]
    public void Theory_MemberData_MultiplyManyNumbers_ShouldReturnTheirMultiplication(decimal expected,
        params decimal[] valuesToMultiply)
    {
        foreach (var value in valuesToMultiply)
        {
            _sut.Multiply(value);
        }

        Assert.Equal(expected, _sut.Value);
    }

    private static IEnumerable<object[]> DivisionTestData()
    {
        yield return new object[] { -51, new decimal[] { 51, -1 }};
        yield return new object[] { 0.625, new decimal[] { 5, 8 }};
        yield return new object[] { 1.6, new decimal[] { 8, 5 }};
    }

    [Theory]
    [MemberData(nameof(DivisionTestData))]
    public void Theory_MemberData_DivideManyNumbers_ShouldReturnTheirDivision(decimal expected,
        params decimal[] valuesToDivide)
    {
        foreach (var value in valuesToDivide)
        {
            _sut.Divide(value);
        }

        Assert.Equal(expected, _sut.Value);
    }
}