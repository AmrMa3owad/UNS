namespace Orion.Shared.Exceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException()
        {
            Errors = new List<string>();
        }
        public List<string> Errors { get; set; }
    }
}
