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

            for (int i = 0; i < iListTest2.Capacity; i++)
            {
                iKzListTestPreSized.Add(i);
            }

            Console.WriteLine(iKzListTestPreSized.Count);
            Console.WriteLine(iKzListTestPreSized.Length);
            iKzListTestPreSized.Remove(0);

            for (int i = 0; i < iKzListTestPreSized.Count; i++)
            {
                Console.WriteLine("Output: " + iKzListTestPreSized[i]);
            }

            Console.WriteLine(iKzListTestPreSized.Count);
            Console.WriteLine(iKzListTestPreSized.Length);

            Console.ReadLine();
        }
    }
}