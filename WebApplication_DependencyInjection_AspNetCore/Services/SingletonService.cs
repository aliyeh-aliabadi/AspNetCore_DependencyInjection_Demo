namespace WebApplication_DependencyInjection_AspNetCore.Services
{
    public class SingletonService : ISingletonService
    {
        public string Time { get; set; }

        public SingletonService()
        {
            Time = DateTime.Now.ToString("HH:mm:ss.ffffff");
        }
    }
}
