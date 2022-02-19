using System.Collections;
using System.Collections.Generic;

namespace xUnitBasics.Tests.CalculatorTests.ClassData;

public class DivisionTestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[] {-51, new decimal[] {51, -1}};
        yield return new object[] {0.625, new decimal[] {5, 8}};
        yield return new object[] {1.6, new decimal[] {8, 5}};
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}