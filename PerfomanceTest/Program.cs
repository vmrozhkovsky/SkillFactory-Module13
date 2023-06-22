using System.Diagnostics;

string text = File.ReadAllText("text1.txt");
List<char> lstChar = new List<char>();
LinkedList<char> linkedListChar = new LinkedList<char>();

TestListPertfomance();
TestLinkedListPertfomance();

void TestListPertfomance()
{
    Stopwatch stopWatch = Stopwatch.StartNew();
    foreach (char ch in text)
    {
        lstChar.Add(ch);
    }
    Console.WriteLine(stopWatch.ElapsedMilliseconds); 
}
void TestLinkedListPertfomance()
{
    Stopwatch stopWatch = Stopwatch.StartNew();
    foreach (char ch in text)
    {
        linkedListChar.AddLast(ch);
    }
    Console.WriteLine(stopWatch.ElapsedMilliseconds); 
}