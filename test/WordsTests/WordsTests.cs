namespace WordsTests;

public class WordsTests
{
    private readonly IFixture _fixture = new Fixture();

    public WordsTests()
    {
        _fixture.Register<IWords>(() => new EnglishAlphaWords());
    }

    [Fact]
    public void Test1()
    {

    }
}