public static class StringRotation
{
    public static string stringRotation(string input, int rotationAmount)
    {
        if (rotationAmount == input.Length)
        {
            return input;
        }

        if (rotationAmount > input.Length)
        {
            int remainderAmount = rotationAmount % input.Length;

            if (remainderAmount == 0)
            {
                return input;
            }
            else
            {
                rotationAmount = remainderAmount;
            }
        }
        
        string newStartSplit = input.Substring(input.Length - rotationAmount);

        string newEndSplit = input.Substring(0, input.Length - rotationAmount);

        return String.Concat(newStartSplit, newEndSplit);
    }
}