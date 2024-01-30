namespace Words;

public class EnglishAlphaWords : ReadOnlyCollection<string>
{
    public EnglishAlphaWords()
        : base(ReadEnglishAlphaWords()) { }

    private static IList<string> ReadEnglishAlphaWords()
    {
        var list = new List<string>();
        using (var reader = new StreamReader("words_alpha.txt"))
        {
            string? word;
            while ((word = reader.ReadLine()) != null)
            {
                list.Add(word);
            }
        }

        return list;
    }
}
