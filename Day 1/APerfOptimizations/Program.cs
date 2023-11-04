using System.Diagnostics;
using System.IO.IsolatedStorage;

namespace APerfOptimizations
{
    internal class Program
    {
        static Random rand = new Random();
        const int DataSize = 10_000_000;
        static int[] data = new int[DataSize];

        static void PopulateData()
        {
            for (int i = 0; i < DataSize; i++)
            {
                data[i] = rand.Next(10);
            }
        }

        static int CountBoundary(int boundary)
        {
            int count = 0;
            for (int i = 0; i < DataSize; i++)
            {
                if (data[i] < boundary) count++;
            }
            return count;
        }

        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();
            PopulateData();
            for (int i = 0; i < 11; i++)
            {
                watch.Restart();
                int count = CountBoundary(i);
                watch.Stop();
                Console.WriteLine($"{i}: count = {count}, " +
                    $"elapsed time: {watch.ElapsedMilliseconds}");
            }
            Console.ReadLine();
        }
    }
}