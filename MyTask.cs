namespace Otus.AsyncAwait
{
    public class MyTask
    {
        public MyAwaiter GetAwaiter()
        {
            return new MyAwaiter();
        }
    }
}
