namespace Otus.AsyncAwait
{
    public class ClassWorkProgram
    {
        public void Example1()
        {
            ThreadPool.SetMaxThreads(20, 20);
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Parallel.ForEach(list, number =>
            {
                WaitAndWrite().GetAwaiter().GetResult();
            });
        }
        
        public async Task Example1Async()
        {
            ThreadPool.SetMaxThreads(20, 20);
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            await Parallel.ForEachAsync(list, async (item, cn) =>
            {
                await WaitAndWrite();
            });
        }

        private async Task WaitAndWrite()
        {
            while (true)
            {
                var time = new Random().Next(1000, 2000);
                await Task.Delay(time);
                ThreadPool.GetAvailableThreads(out var x, out var y);
                Console.WriteLine(x + y);    
            }
        }

        public async Task Program1()
        {
            var result = await GetInt();
            Console.WriteLine(result);
        }
        
        public async Task<int> GetInt()
        {
            throw new ArgumentException("");
            return await Task.FromResult(new Random().Next());
        } 
    }
}
