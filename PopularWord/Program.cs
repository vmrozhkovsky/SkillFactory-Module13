string text = File.ReadAllText("text1.txt");
string noPunctuationText = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());
string[] wordMassive = noPunctuationText.Replace("\n", "").Split(" ");

Dictionary<string, int> wordDictionary = new Dictionary<string, int>();

foreach (string world in wordMassive.Where(x => x != ""))
{
    if (wordDictionary.ContainsKey(world))
    {
        wordDictionary[world] = wordDictionary[world] + 1;
    }
    else
    {
        wordDictionary.Add(world, 1);
    }
}

int number = 1;
foreach (var pair in wordDictionary.OrderByDescending(pair => pair.Value).Take(10))
{
    Console.WriteLine("{0}. {1} - {2}", number, pair.Key, pair.Value);
    number++;
}

