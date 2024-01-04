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
        var words = text.Split(' ');
        var matches = words.Where(x => _words.Contains(x)).Count();
        return (double)matches / words.Count();
    }
}
