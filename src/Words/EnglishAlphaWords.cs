namespace Words;

public class EnglishAlphaWords : List<string>
{
    public EnglishAlphaWords()
    {
        using (var reader = new StreamReader("words_alpha.txt"))
        {
            string word;
            while ((word = reader.ReadLine()) != null)
            {
                Add(word);
            }
        }
    }
}
