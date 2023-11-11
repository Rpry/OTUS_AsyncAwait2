namespace Otus.AsyncAwait
{
    public class ThreadsProgram
    {
        public void Example1()
        {
            Console.WriteLine($"Start method {TaskScheduler.Current}");
        }
        
        public void Example2()
        {
            Console.WriteLine($"Start method {SynchronizationContext.Current}");
            Console.WriteLine($"Start method {TaskScheduler.Current}");
        }
        
        public void Example3()
        {
            Console.WriteLine(GetTitleAsync().Result);
        }
        
        private static async Task<string> GetTitleAsync()
        {
            await Task.Delay(1000).ConfigureAwait(true);
            //метод должен быть закончен в исходном потоке, но тот заблокирован ожиданием Result
            return "abc";
        }
    }
}
