namespace Words;

public class EnglishAlphaWords : ICollection<string>
{
    private ICollection<string> _list = new List<string();

    public EnglishAlphaWords()
    {
        using (var reader = new StreamReader("../../english-words/words_alpha.txt"))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                _list.Add(line);
            }
        }
    }
}