namespace ERaceConditionDemo
{
    internal class Program
    {
        static int data = 100;

        static object objLock = new object();

        static void Worker(object tag)
        {
            int tmpData;
            for (int i = 0; i < 10; i++)
            {
                lock (objLock)
                {
                    data++;
                    Thread.Sleep(3);
                    data--;
                    tmpData = data;
                }
                //Synonym to:
                /* Monitor.Enter(objLock);
                 * try 
                 * { 
                 * 
                 * }
                 * finally 
                 * {
                 *    Monitor.Exit(objLock);
                 * }
                 */
                Console.WriteLine($"{tag}: {tmpData}");
            }
        }

        static void Main(string[] args)
        {
            Thread t1 = new Thread(Worker);
            Thread t2 = new Thread(Worker);
            t1.Start("A");
            t2.Start("B");
        }
    }
}