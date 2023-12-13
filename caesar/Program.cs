using System.Text;

var cyphertext = args[0].ToUpperInvariant();

Console.WriteLine($" 0 {cyphertext}");

for (int k = 1; k < 26; k++)
{
    var plaintext = new StringBuilder(cyphertext.Length);
    for (int i = 0; i < cyphertext.Length; i++)
    {
        var c = cyphertext[i];
        if (Char.IsLetter(c))
        {
            plaintext.Append((char)(((c - 65 + k) % 26) + 65));
        }
        else
        {
            plaintext.Append(c);
        }
    }

    Console.WriteLine($"{k,2} {plaintext.ToString().ToLowerInvariant()}");

}
