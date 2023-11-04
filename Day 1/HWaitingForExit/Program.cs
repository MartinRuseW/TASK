namespace HWaitingForExit
{
    internal class Program
    {
        static void ThreadMethod()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(100);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Starting a thread.");
            Thread t = new Thread(ThreadMethod);
            t.Start();

            Console.WriteLine("Waiting for the thread to end.");
            t.Join(); //Causes the current thread (i.e., Main()'s thread) to stop and wait.
            Console.WriteLine("Thread ended.");

            Console.ReadLine();
        }
    }
}