﻿var digraphs = new Dictionary<string, int>();

using (var reader = new StreamReader("./shakespeare.txt"))
{
    string? line;
    while ((line = reader.ReadLine()) != null)
    {
        line = line.Trim().ToUpperInvariant();
        for (int i = 0; i < line.Length - 1; i++)
        {
            if (char.IsLetter(line[i]) && char.IsLetter(line[i + 1]))
            {
                var digraph = $"{line[i]}{line[i+1]}";
                if (digraphs.ContainsKey(digraph))
                {
                    digraphs[digraph]++;
                }
                else
                {
                    digraphs.Add(digraph, 1);
                }
            }
        }
    }
}

var count = digraphs.Values.Sum();

Console.WriteLine($"Found {digraphs.Count} digraphs");

foreach (var item in digraphs.Select(x => new {Key = x.Key.ToLowerInvariant(), Probability = (double)x.Value / count, Count = x.Value})
        .OrderByDescending(x => x.Probability)
        .Take(20))
{
    Console.WriteLine($"{item.Key} {item.Probability * 100:0.00}% {item.Count,7} {count,7}");
}
