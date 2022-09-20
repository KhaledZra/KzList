using System.Diagnostics;

namespace KzList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stopwatch watch = Stopwatch.StartNew();

            List<int> iListTest1 = new List<int>();
            List<int> iListTest2 = new List<int>(10);

            KzList<int> iKzListTest = new KzList<int>();
            KzList<int> iKzListTestPreSized = new KzList<int>(10);

            Console.Clear();
            Console.WriteLine("Debugging menu");

            for (int i = 0; i < 10; i++)
            {
                iKzListTest.Add(i);
            }
            iKzListTest.Add(2);

            iKzListTest.SortAscending();

            for (int i = 0; i < iKzListTest.Count; i++)
            {
                Console.WriteLine("Output: " + iKzListTest[i]);
            }

            Console.ReadLine();
        }
    }
}