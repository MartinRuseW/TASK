using System.IO.IsolatedStorage;

namespace GMultipleResults
{
    internal class Program
    {
        const int Count = 10;
        static Random rand = new Random();
        static int[] results = new int[Count];

        static void ThreadMethod(object indxObj)
        {
            int index = (int)indxObj;
            results[index] = rand.Next(100) + 1;
        }

        static void Main(string[] args)
        {
            Thread[] threads = new Thread[Count];
            for (int i = 0; i < Count; i++)
            {
                Thread t = new Thread(ThreadMethod);
                t.Start(i);
                threads[i] = t;
            }
            Console.WriteLine("Press ENTER to see the result.");
            Console.ReadLine();
            foreach (var t in threads) t.Join();
            int sum = results.Sum();
            Console.WriteLine(sum);
        }
    }
}