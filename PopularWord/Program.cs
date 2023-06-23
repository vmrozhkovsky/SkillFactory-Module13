SortWriteDictionary(AddWordToDictionary(ReadFile()));

//Метод чтения файла и удаление из строки знаков пунктуации и переносов строки. Возвращает массив из слов.
string[] ReadFile()
{
    Console.WriteLine("Введите путь и название файла для чтения (оставьте пустым, чтобы использовать файл text.txt в папке проекта):");
    while (true)
    {
        string file = Console.ReadLine();
        if (file == "")
        {
            file = "text.txt";
        }
        if (File.Exists(file))
        {
            string text = File.ReadAllText(file);
            string noPunctuationText = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());
            string[] wordMassive = noPunctuationText.Split(" ");
            return wordMassive;
        }
        Console.WriteLine("Указанный файл не существует. Попробуйте снова:");
    }
}

//Метод добавления слов (ключи) и количества повторений (значения) в словарь. Если слово в словаре уже есть - увеличение значения на 1. Возвращает словарь.
Dictionary<string, int> AddWordToDictionary(string[] wordMassive)
{
    Console.WriteLine("Обработка текта...");
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
    return wordDictionary;
}

//Метод сортировки словаря по уменьшению значения и вывод первых десяти пар в консоль.
void SortWriteDictionary(Dictionary<string, int> wordDictionary)
{
    Console.WriteLine("10 самых популярных слов в вашем файле:");
    int number = 1;
    foreach (var pair in wordDictionary.OrderByDescending(pair => pair.Value).Take(10))
    {
        Console.WriteLine("{0}. {1} - {2}", number, pair.Key, pair.Value);
        number++;
    }
}

