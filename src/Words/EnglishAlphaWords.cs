namespace Words;

using System.Collections.ObjectModel;

public class EnglishAlphaWords : ReadOnlyCollection<string>
{
    public EnglishAlphaWords()
        : base(new string[0])
    {
    }
}