namespace FThreadParams
{
    internal class Program
    {
        static void ThreadMethod(object p)
        {
            string tag = p.ToString();
            Console.WriteLine($"Hello from thread {tag}!");
        }

        static void Main(string[] args)
        {
            Thread a = new Thread(ThreadMethod);
            Thread b = new Thread(ThreadMethod);
            Thread c = new Thread(ThreadMethod);
            a.Start("A");
            b.Start("B");
            c.Start("C");

            Console.ReadLine();
        }
    }
}