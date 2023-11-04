namespace JCarefulWithThatJoin
{
    internal class Program
    {
        static void ThreadMethod(object tagObj)
        {
            Console.WriteLine($"{tagObj} starts.");
            Thread.Sleep(1000);
            Console.WriteLine($"{tagObj} ends.");
        }

        static void Main(string[] args)
        {
            int count = 10;
            var threads = new Thread[count];
            for (int i = 0; i < count; i++)
            {
                threads[i] = new Thread(ThreadMethod);
                threads[i].Start(i);
                //threads[i].Join(); This MUST NOT be here.  It will turn the program into a sequence.
            }
            foreach (var t in threads) t.Join();
            Console.WriteLine("Press ENTER to quit.");
            Console.ReadLine();
        }
    }
}