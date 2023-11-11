namespace Otus.AsyncAwait
{
    public class ChildTasksProgram
    {
        public async Task RunAsync()
        {
            var parent = Task.Factory.StartNew(() => {
                Console.WriteLine("Outer task executing.");

                var child = Task.Factory.StartNew(() => {
                    Console.WriteLine("Nested task starting.");
                    //Thread.SpinWait(500000);
                    Console.WriteLine("Nested task completing.");
                });
                child.Wait();
            });

            await parent;
            Console.WriteLine("Outer has completed.");
        }
    }
}
