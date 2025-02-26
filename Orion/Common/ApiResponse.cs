using Orion.Shared.Enums;

namespace Orion.Common
{
    public class ApiResponse<T>
    {
        public bool Success { get;private set; }
        public T Data { get; set; }
        public List<string> ErrorMessages { get;set; }
        ErrorCodes _errorCode { get; set; }
        public ErrorCodes ErrorCode
        {
            get
            {
                return _errorCode;
            }
            set
            {
                Success = false;
                _errorCode = value;
                ErrorMessages = new List<string> { _errorCode.ToString() } ;
            }
        }

        public ApiResponse()
        {
            Success = true;
            ErrorMessages= new List<string>();      
        }
    }
}
