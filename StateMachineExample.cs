namespace Otus.AsyncAwait
{
    public class StateMachineExample
    {
        public async Task PrintAndWaitAsync(TimeSpan delay, int arg2)
        {
            Console.WriteLine("Before first delay");
            await Task.Delay(delay);
            Console.WriteLine("Between delays");
            await Task.Delay(delay);
            Console.WriteLine("After second delay");    
        }
    }
}
