namespace IWaitingForExitNonBlocking
{
    internal class Program
    {
        static volatile bool threadIsRunning; //volatile is not needed for C#, but critical for Java and C++
        static void ThreadWorker()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(100);
            }
            threadIsRunning = false;
        }

        static void Main(string[] args)
        {
            Thread t = new Thread(ThreadWorker);
            threadIsRunning = true;
            t.Start();

            Console.Write("Waiting for the thread to quit: ");
            while (threadIsRunning)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
            Console.WriteLine("");
            Console.WriteLine("Thread completed.");
            Console.ReadLine();
        }
    }
}