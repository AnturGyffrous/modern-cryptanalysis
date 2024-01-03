namespace Words;

using System.Collections.ObjectModel;

public class EnglishAlphaWords : ReadOnlyCollection<string>, IWords
{
    public EnglishAlphaWords(IList<string> list) : base(list)
    {
    }
}