namespace WordsTests;

public class MatchedWordsTests
{
    [Fact]
    public void CalculateShouldBeOneHundredPercentIfAllWordsMatch()
    {
        // Arrange
        var words = new List<string>
        {
            "the",
            "quick",
            "brown",
            "fox",
            "jumps",
            "over",
            "lazy",
            "dog"
        };
        var sut = new MatchedWords(words);

        // Act
        var result = sut.Calculate("the quick brown fox jumps over the lazy dog");

        // Assert
        result.Should().Be(1);
    }

    [Fact]
    public void CalculateShouldBeOneHundredPercentIfAllWordsMatchRegardlessOfCase()
    {
        // Arrange
        var words = new List<string>
        {
            "the",
            "quick",
            "brown",
            "fox",
            "jumps",
            "over",
            "lazy",
            "dog"
        };
        var sut = new MatchedWords(words);

        // Act
        var result = sut.Calculate("THE quick brown Fox jumps over the lazy Dog");

        // Assert
        result.Should().Be(1);
    }

    [Fact]
    public void CalculateShouldBeFiftyPercentIfHalfTheWordsMatch()
    {
        // Arrange
        var words = new List<string> { "to", "be", "question" };
        var sut = new MatchedWords(words);

        // Act
        var result = sut.Calculate("to be or not to be that is the question");

        // Assert
        result.Should().Be(0.5);
    }

    [Fact]
    public void CalculateShouldBeZeroPercentIfNoWordsMatch()
    {
        // Arrange
        var words = new List<string>
        {
            "the",
            "quick",
            "brown",
            "fox",
            "jumps",
            "over",
            "lazy",
            "dog"
        };
        var sut = new MatchedWords(words);

        // Act
        var result = sut.Calculate("iwt fjxrz qgdlc udm yjbeh dktg iwt apon sdv");

        // Assert
        result.Should().Be(0);
    }
}
