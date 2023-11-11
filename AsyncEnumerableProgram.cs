namespace Otus.AsyncAwait
{
    public class AsyncEnumerableProgram
    {
        public async Task RunAsync()
        {
            await foreach (var item in GetProcessedDataAsync())
            {
                Console.WriteLine($"Displaying: {item}");
            }
        }
        
        public async Task RunViaListAsync()
        {
            foreach (var item in await GetProcessedDataViaListAsync())
            {
                Console.WriteLine($"Displaying: {item}");
            }
        }

        private async IAsyncEnumerable<string> GetProcessedDataAsync()
        {
            for (int i = 0; i < 10; i++)
            {
                yield return await GetProcessed(i);
            }
        }

        private async Task<List<string>> GetProcessedDataViaListAsync()
        {
            List<string> list = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(await GetProcessed(i));
            }

            return list;
        }

        private async Task<string> GetProcessed(int number)
        {
            await Task.Delay(new Random().Next(1000, 2000));
            Console.WriteLine($"Got service result N{number}..");//(thread {Thread.CurrentThread.ManagedThreadId})");
            return $"result N{number}";
        }
    }
}
