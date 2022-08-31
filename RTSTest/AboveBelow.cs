public static class AboveBelow
{
    public static AboveBelowResponse aboveBelow(List<int> unsortedIntegers, int comparisonValue)
    {
        return new AboveBelowResponse()
        {
            Above = unsortedIntegers.Count(ui => ui > comparisonValue),
            Below = unsortedIntegers.Count(ui => ui < comparisonValue)
        };
    }

    public static AboveBelowResponse aboveBelowOptimized(List<int> unsortedIntegers, int comparisonValue)
    {
        var response = new AboveBelowResponse();

        foreach(int integer in unsortedIntegers)
        {
            if (integer < comparisonValue)
            {
                response.Below++;
            }
            else if (integer > comparisonValue)
            {
                response.Above++;
            }
        }

        return response;
    }
}