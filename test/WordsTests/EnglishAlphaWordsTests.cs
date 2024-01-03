namespace WordsTests;

public class EnglishAlphaWordsTests
{
    [Theory]
    [InlineData("the")]
    [InlineData("quick")]
    [InlineData("brown")]
    [InlineData("fox")]
    [InlineData("jumps")]
    [InlineData("over")]
    [InlineData("lazy")]
    [InlineData("dog")]
    public void ContainsShouldReturnTrueIfWordExistsInCollection(string word)
    {
        // Arrange
        var sut = new EnglishAlphaWords();

        // Act
        var result = sut.Contains(word);

        // Assert
        result.Should().BeTrue();
    }

    [Fact]
    public void ContainsShouldReturnFalseIfWordDoesNotExistsInCollection()
    {
        // Arrange
        var sut = new EnglishAlphaWords();

        // Act
        var result = sut.Contains("zgxsmnmfrkskagpvhpiulvhagrg");

        // Assert
        result.Should().BeFalse();
    }
}