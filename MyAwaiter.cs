using System.Runtime.CompilerServices;

namespace Otus.AsyncAwait
{
    public class MyAwaiter : INotifyCompletion
    {
        public void OnCompleted(Action continuation)
        {
            Console.WriteLine("Running on completed!");
        }

        public bool IsCompleted
        {
            get
            {
                Console.WriteLine("Running isCompleted!");
                return true;
            }
        }

        public int GetResult()
        {
            Console.WriteLine("Running GetResult!");
            return 1;
        }
    }
}
