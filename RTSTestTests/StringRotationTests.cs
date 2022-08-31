public class StringRotationTests
{
    [Theory]
    [InlineData("MyString", 2, "ngMyStri")] // Sample
    [InlineData("MyString", 8, "MyString")] // Same Length
    [InlineData("MyString", 16, "MyString")] // Double Length
    [InlineData("MyString", 17, "gMyStrin")] // Over length, not even division
    [InlineData(null, 17, null)] // Null
    [InlineData("", 17, "")] // Empty
    [InlineData("MyString", 0, "MyString")] // 0 rotation
    [InlineData("MyString", -2, "MyString")] // Negative rotation
    public void CanRotateString(string inputString, int rotationAmount, string expectedString)
    {
        // Act 
        string response = StringRotation.stringRotation(inputString, rotationAmount);

        // Assert
        Assert.Equal(expectedString, response);
    }
}