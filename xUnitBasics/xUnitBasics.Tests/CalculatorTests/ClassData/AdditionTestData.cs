using System.Collections;
using System.Collections.Generic;

namespace xUnitBasics.Tests.CalculatorTests.ClassData;

public class AdditionTestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[] { 15, new decimal[] { 10, 5 }};
        yield return new object[] { 15, new decimal[] { 5, 5, 5 }};
        yield return new object[] { -10, new decimal[] { -30, 20 }};
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}