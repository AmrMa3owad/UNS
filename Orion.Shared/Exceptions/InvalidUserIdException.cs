namespace Orion.Shared.Exceptions
{
    public class InvalidUserIdException : Exception
    {
        public InvalidUserIdException() 
        { 
            Errors = new List<string>();
        }
        public List<string> Errors { get; set; }
    }
}
