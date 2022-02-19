using System.Collections;
using System.Collections.Generic;

namespace xUnitBasics.Tests.CalculatorTests.ClassData;

public class SubtractionTestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[] {0, new decimal[] {0, 0}};
        yield return new object[] {-1, new decimal[] {1, 0}};
        yield return new object[] {-1, new decimal[] {0, 1}};
        yield return new object[] {-50, new decimal[] {51, -1}};
        yield return new object[] {-21, new decimal[] {13, 8}};
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}