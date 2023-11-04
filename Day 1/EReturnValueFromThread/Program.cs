namespace EReturnValueFromThread
{
    internal class Program
    {
        static Random rand = new Random();
        static int threadMagicValue;
        
        static void ThreadCompute()
        {
            int magicValue = rand.Next(100) + 1;
            threadMagicValue = magicValue;
        }

        static void Main(string[] args)
        {
            Thread t = new Thread(ThreadCompute);
            t.Start();
            Console.WriteLine("Press ENTER to see the result of the thread.");
            Console.ReadLine();
            Console.WriteLine($"Thread result is: {threadMagicValue}");
        }
    }
}