using System.Diagnostics;

namespace KzList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stopwatch watch = Stopwatch.StartNew();
            Random ran = new Random();

            List<int> iListTest1 = new List<int>();
            List<int> iListTest2 = new List<int>(10);

            KzList<string> iKzListTest = new KzList<string>();
            KzList<int> iKzListTestPreSized = new KzList<int>(10);

            Console.Clear();
            Console.WriteLine("Debugging menu");

            iListTest1.Clear();

            //for (int i = 0; i < 10; i++)
            //{
            //    iKzListTest.Add(ran.Next(100));
            //}

            iKzListTest.Add("Kalle");
            iKzListTest.Add("Carl");
            iKzListTest.Add("Adam");

            iKzListTest.SortAscending();
            //iKzListTest.SortDescending();



            for (int i = 0; i < iKzListTest.Count; i++)
            {
                Console.WriteLine("Output: " + iKzListTest[i]);
            }

            Console.ReadLine();
        }
    }
}