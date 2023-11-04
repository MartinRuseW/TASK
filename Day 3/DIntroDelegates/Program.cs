namespace DIntroDelegates
{
    internal class Program
    {
        static bool IfOdd (int n)
        {
            return n % 2 == 0;
        }

        static void DoSomething() { Console.WriteLine("Hi there!"); }

        static void PrintString(string str) { Console.WriteLine(str.ToUpper()); }

        delegate void MyDelegate();
        delegate void StringDelegate(string str);
        


        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 10, 6, 12, 77, 4 };

            numbers.FindAll(IfOdd);

            MyDelegate d1;
            d1 = DoSomething;
            d1();

            StringDelegate d2 = PrintString;
            d2("Hi there again");
        }
    }
}