namespace RTSTestTests;

public class AboveBelowUnitTests
{
    private static IEnumerable<object[]> AboveBelowData()
    {
        // unsortedList | comparison value | expected above | expected below
        yield return new object[] { new List<int>() {1, 5, 2, 1, 10 }, 6, 1, 4 }; // Sample
        yield return new object[] { new List<int>() {1, 1, 1, 1 }, 1, 0, 0 }; // All Same Number
        yield return new object[] { new List<int>() {2, 3, 4, 5 }, 1, 4, 0 }; // All Above
        yield return new object[] { new List<int>() {2, 3, 4, 5 }, 6, 0, 4 }; // All Below
    }

    private static IEnumerable<object[]> AboveBelowBadData()
    {
        // unsortedList | comparison value | expected above | expected below
        yield return new object[] { new List<int>(), 6, 0, 0 }; // Empty list
    }

    [Theory]
    [MemberData(nameof(AboveBelowData))]
    public void CanCalculateAboveBelow(List<int> unsortedList, int comparisonValue, int expectedAbove, int expectedBelow)
    {
        // Act 
        var response = AboveBelow.aboveBelow(unsortedList, comparisonValue);

        // Assert
        Assert.Equal(expectedAbove, response.Above);
        Assert.Equal(expectedBelow, response.Below);
    }

    [Theory]
    [MemberData(nameof(AboveBelowBadData))]
    public void CanHandleBadAboveBelowBadInputs(List<int> unsortedList, int comparisonValue, int expectedAbove, int expectedBelow)
    {
        // Act 
        var response = AboveBelow.aboveBelow(unsortedList, comparisonValue);

        // Assert
        Assert.Equal(expectedAbove, response.Above);
        Assert.Equal(expectedBelow, response.Below);
    }

    [Theory]
    [MemberData(nameof(AboveBelowData))]
    public void CanCalculateAboveBelowOptimized(List<int> unsortedList, int comparisonValue, int expectedAbove, int expectedBelow)
    {
        // Act 
        var response = AboveBelow.aboveBelowOptimized(unsortedList, comparisonValue);

        // Assert
        Assert.Equal(expectedAbove, response.Above);
        Assert.Equal(expectedBelow, response.Below);
    }

    [Theory]
    [MemberData(nameof(AboveBelowBadData))]
    public void CanHandleBadAboveBelowOptimizedBadInputs(List<int> unsortedList, int comparisonValue, int expectedAbove, int expectedBelow)
    {
        // Act 
        var response = AboveBelow.aboveBelowOptimized(unsortedList, comparisonValue);

        // Assert
        Assert.Equal(expectedAbove, response.Above);
        Assert.Equal(expectedBelow, response.Below);
    }
}