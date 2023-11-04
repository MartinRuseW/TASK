namespace CFirstThread
{
    internal class Program
    {
        static void MyFirstThreadMethod()
        {
            Console.WriteLine("Hello from my first thread!");
        }

        static void Main(string[] args)
        {
            Thread thread;
            thread = new Thread(MyFirstThreadMethod);
            thread.Start();
            Console.WriteLine("Hello from Main().");

            Console.ReadLine();
        }
    }
}