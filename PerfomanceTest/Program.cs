using System.Diagnostics;
//Чтение файла
string text = File.ReadAllText("text1.txt");

//Создание листов для тестирования
List<char> lstChar = new List<char>();
LinkedList<char> linkedListChar = new LinkedList<char>();

//Запуск методов тестирования 
TestListPertfomance();
TestLinkedListPertfomance();

//Метод для тестирования простого листа
void TestListPertfomance()
{
    Stopwatch stopWatch = Stopwatch.StartNew();
    foreach (char ch in text)
    {
        lstChar.Add(ch);
    }
    Console.WriteLine(stopWatch.ElapsedMilliseconds); 
}

//Метод для тестирования связанного листа
void TestLinkedListPertfomance()
{
    Stopwatch stopWatch = Stopwatch.StartNew();
    foreach (char ch in text)
    {
        linkedListChar.AddLast(ch);
    }
    Console.WriteLine(stopWatch.ElapsedMilliseconds); 
}