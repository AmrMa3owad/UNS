namespace Orion.Context
{
    public interface IAppContext
    {
         string UserId { get; set; }
    }
    public class AppContext : IAppContext
    {
        public string UserId { get; set; }
    }
}
