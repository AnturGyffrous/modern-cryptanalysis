namespace WordsTests;

public class EnglishAlphaWordsTests
{
    [Theory]
    [InlineData("the")]
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