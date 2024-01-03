namespace WordsTests;

public class EnglishAlphaWordsTests
{
    [Fact]
    public void ContainsShouldReturnTrueIfWordExistsInCollection()
    {
        // Arrange
        var sut = new EnglishAlphaWords();

        // Act
        var result = sut.Contains("the");

        // Assert
        result.Should().BeTrue();
    }
}