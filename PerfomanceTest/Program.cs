using System.Diagnostics;
//Чтение файла
string text = File.ReadAllText("text1.txt");

//Запуск методов тестирования 
TestListPertfomance();
TestLinkedListPertfomance();

//Метод для тестирования простого листа
void TestListPertfomance()
{
    List<char> simpleListChar = new List<char>();
    Stopwatch stopWatch = Stopwatch.StartNew();
    foreach (char ch in text)
    {
        simpleListChar.Add(ch);
    }

    Console.WriteLine($"Время, потраченное на добавление {simpleListChar.Count} символов в простой лист - {stopWatch.ElapsedMilliseconds} милисекунд.");
}

//Метод для тестирования связанного листа
void TestLinkedListPertfomance()
{
    LinkedList<char> linkedListChar = new LinkedList<char>();
    Stopwatch stopWatch = Stopwatch.StartNew();
    foreach (char ch in text)
    {
        linkedListChar.AddLast(ch);
    }
    Console.WriteLine($"Время, потраченное на добавление {linkedListChar.Count} символов в связанный лист - {stopWatch.ElapsedMilliseconds} милисекунд.");
}