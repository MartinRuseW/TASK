using System.Data;
using System.Diagnostics.CodeAnalysis;

namespace BCancellingThreadsNaive
{
    internal class Program
    {
        static bool workerCompleted;
        static bool askedToStop;
        static void ThreadWorker()
        {
            try
            {
                Console.WriteLine("Worker starts.");
                for (int i = 0; i < 100; i++)
                {
                    Thread.Sleep(100);
                    if (askedToStop)
                    {
                        Console.WriteLine("Worker cancelled.");
                        return;
                    }
                }
                Console.WriteLine("Worker ends.");
            }
            finally
            {
                workerCompleted = true;
            }
        }

        static void Main(string[] args)
        {
            Thread t = new Thread(ThreadWorker);
            workerCompleted = false;
            askedToStop = false;
            t.Start();
            Console.Write("Waiting for the worker to complete (Press C to cancel): ");
            while (!workerCompleted)
            {
                Console.Write(".");
                Thread.Sleep(500);
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey();
                    if (Char.ToLower(key.KeyChar) == 'c')
                    {
                        //let's interrupt the thread.
                        askedToStop = true;
                    }
                }
                
            }
            Console.WriteLine();
            Console.WriteLine("Press ENTER to quit.");
            Console.ReadLine();
        }
    }
}