using System.Collections;
using System.Collections.Generic;

namespace xUnitBasics.Tests.CalculatorTests.ClassData;

public class MultiplicationTestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[] {0, new decimal[] {0, 0}};
        yield return new object[] {0, new decimal[] {1, 0}};
        yield return new object[] {0, new decimal[] {0, 1}};
        yield return new object[] {-51, new decimal[] {51, -1}};
        yield return new object[] {6, new decimal[] {3, 2}};
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}