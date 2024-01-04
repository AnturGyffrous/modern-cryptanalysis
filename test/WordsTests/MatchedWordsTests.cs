namespace WordsTests;

public class MatchedWordsTests
{
    [Fact]
    public void CalculateShouldBeOneHundredPercentIfAllWordsMatch()
    {
        // Arrange
        var words = new List<string> { "the", "quick", "brown", "fox", "jumps", "over", "lazy", "dog" };
        var sut = new MatchedWords(words);

        // Act
        var result = sut.Calculate("the quick brown fox jumps over the lazy dog");
    }
}
