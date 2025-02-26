namespace Orion.Shared.Exceptions
{
    public class CreateException : Exception
    {
        public CreateException()
        {
            ErrorCodes = new List<string>();
            ErrorDescriptions = new List<string>();
        }
        public List<string> ErrorCodes { get; set; }
        public List<string> ErrorDescriptions { get; set; }
    }
}
