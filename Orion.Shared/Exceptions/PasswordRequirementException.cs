namespace Orion.Shared.Exceptions
{
    public class PasswordRequirementException : Exception
    {
        public PasswordRequirementException()
        {
            Errors = new List<string>();
        }
        public List<string> Errors { get; set; }
    }
}
