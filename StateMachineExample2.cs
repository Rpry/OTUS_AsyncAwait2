namespace Otus.AsyncAwait
{
    public class StateMachineExample2
    {
        public async Task PrintAndWaitAsync()
        {
            Console.WriteLine("Before delay");
            var result = await GetInt();
            Console.WriteLine($"After delay {result}");
        }

        public async Task<int> GetInt()
        {
            return await Task.FromResult(new Random().Next());
        }
    }
}
