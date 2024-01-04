namespace Words;

public class MatchedWords
{
    private ICollection<string> _words;

    public MatchedWords(ICollection<string> words)
    {
        _words = words;
    }

    public double Calculate(string text)
    {
        return 1;
    }
}
