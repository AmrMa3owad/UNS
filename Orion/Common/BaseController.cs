using Microsoft.AspNetCore.Mvc;
using Orion.Context;
using Orion.Handlers;
using System.Security.Claims;

namespace Orion.Common
{
    public abstract class BaseController : ControllerBase
    {
        private readonly ILogger _logger;
        public IClaimHandler ClaimHandler { get; }


        public BaseController(ILogger logger,
            IClaimHandler claimHandler)
        {
            ClaimHandler = claimHandler;
            _logger = logger;

            IHttpContextAccessor httpContext = AppScope.App.Services
            .GetRequiredService<IHttpContextAccessor>();

            IAppContext appContext = httpContext.HttpContext.
            RequestServices.GetService<IAppContext>();

            if (httpContext.HttpContext != null &&
                httpContext.HttpContext.User != null &&
                httpContext.HttpContext.User.Identity.IsAuthenticated)
            {
                appContext.UserId = httpContext.HttpContext.User
                    .FindFirst(ClaimTypes.NameIdentifier).Value;
            }
        }
        
        internal void Log(LogLevel logLevel, string message, string additionalParam )
        {
            _logger.Log(logLevel, message, additionalParam);
        }

    }
}
