using Microsoft.AspNetCore;

namespace AndriiKutenWithChatGPT 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args)
        {
            var app = WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();

            return app;
        }
    }
}

