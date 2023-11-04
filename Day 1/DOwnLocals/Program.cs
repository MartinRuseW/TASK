namespace DOwnLocals
{
    internal class Program
    {
        static Random rand = new Random();
        static void ThreadMethod()
        {
            int number;
            number = rand.Next(100) + 1;
            Console.WriteLine($"My number is: {number}");
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Thread t = new Thread(ThreadMethod);
                t.Start();
            }

            Console.WriteLine("Hello, World!");
        }
    }
}