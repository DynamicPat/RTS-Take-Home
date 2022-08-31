public class StringRotationTests
{
    [Theory]
    [InlineData("MyString", 2, "ngMyStri")] // Sample
    [InlineData("MyString", 8, "MyString")] // Same Length
    [InlineData("MyString", 16, "MyString")] // Double Length
    [InlineData("MyString", 17, "gMyStrin")] // Over length, not even division
    public void CanRotateString(string inputString, int rotationAmount, string expectedString)
    {
        // Act 
        string response = StringRotation.stringRotation(inputString, rotationAmount);

        // Assert
        Assert.Equal(expectedString, response);
    }
}