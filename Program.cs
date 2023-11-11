namespace Otus.AsyncAwait
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var awaitableProgram = new AwaitableProgram();
            //await awaitableProgram.Example1(); //MyAwaitable 
            
            var stateMachineExample = new StateMachineExample();
            //await stateMachineExample.PrintAndWaitAsync(TimeSpan.Zero, 0);
            
            var stateMachineExample2 = new StateMachineExample2();
            //await stateMachineExample2.PrintAndWaitAsync();
            
            var threadsProgram = new ThreadsProgram();
            threadsProgram.Example1(); //TaskScheduler
            //threadsProgram.Example2(); //SynchronizationContext and TaskScheduler
            //threadsProgram.Example3(); // deadlock try
            
            var classWorkProgram = new ClassWorkProgram();
            //classWorkProgram.Example1(); // threadPool
            //await classWorkProgram.Example1Async(); //threadPool2
            
            //await classWorkProgram.Program1();
            
            var childTasksProgram = new ChildTasksProgram();
            //await childTasksProgram.RunAsync();

            var asyncEnumerableProgram = new AsyncEnumerableProgram();
            //await asyncEnumerableProgram.RunAsync();
            //await asyncEnumerableProgram.RunViaListAsync();
        }
    }
}