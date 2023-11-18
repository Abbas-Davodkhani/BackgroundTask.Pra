namespace Hangfire
{
    internal class Program
    {
 
        static void Main(string[] args)
        {
            using (var sw = new BackgroundJobServer())
            {
                var fire = BackgroundJob.Enqueue(
                () => Console.WriteLine("\"Fire-and-forget!\""));
            }
            

            Console.ReadKey();                          
        }
    }
}