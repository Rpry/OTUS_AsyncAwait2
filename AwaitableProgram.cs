namespace Otus.AsyncAwait
{
    public class AwaitableProgram
    {
        public async Task Example1()
        {
            var myTask = new MyTask(); 
            await myTask;
            Console.WriteLine("End method");
        }
    }
}
