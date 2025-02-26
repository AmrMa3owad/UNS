using System.Security.Claims;

namespace Orion.Handlers
{
    public class ClaimHandler : IClaimHandler
    {
        private readonly IHttpContextAccessor _contextAccessor;
        public ClaimHandler(IHttpContextAccessor httpContextAccessor) {
            _contextAccessor = httpContextAccessor;

        }
        private ClaimsPrincipal User 
        { 
            get
            {
                if (_contextAccessor!= null 
                    && _contextAccessor.HttpContext != null 
                    && _contextAccessor.HttpContext.User != null)
                {
                    return _contextAccessor
                      .HttpContext
                      .User;
                }
                return null;
            }
        }       

        public Guid? UserId
        {
            get
            {
                if (User != null)
                {
                    Claim claim = User
                     .Claims
                     .Where(x => x.Type == ClaimTypes.NameIdentifier)
                     .FirstOrDefault();
                    if (claim != null)
                    {
                        return new Guid(claim.Value);
                    }

                }
                return null;
            }
        }
    }
}
