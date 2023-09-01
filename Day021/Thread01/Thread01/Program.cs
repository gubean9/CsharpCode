namespace Thread01
{
    internal class Program
    {
        static void threadFunc()
        {
            Console.WriteLine("5초 후 종료");
            Thread.Sleep(10000);
            Console.WriteLine("스레드 종료");
        }
        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(threadFunc));
            t.IsBackground = true;
            t.Start();
            t.Join();
            Console.WriteLine("메인 스레드 종료");
        }
    }
}