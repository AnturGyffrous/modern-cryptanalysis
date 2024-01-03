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
}