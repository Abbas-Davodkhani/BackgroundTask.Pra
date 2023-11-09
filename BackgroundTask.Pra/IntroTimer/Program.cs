namespace IntroTimer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer(Program.WriteOnlinUsersCount);

            Console.ReadKey();  
        }

        public static void WriteOnlinUsersCount(object stateInfo)
        {
            Random random = new Random();
            Console.WriteLine(random.Next(50, 80));
        }
    }

    public class OnlineUser
    {
        
    }
}