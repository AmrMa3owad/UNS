using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Orion.Common;
using Orion.Domain.Models;
using Orion.Infrastructure.Services;
using Orion.Shared.Exceptions;

namespace Orion.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]

    public class WebsiteController : ControllerBase
    {
        private readonly IWebsiteService _websiteService;

        public WebsiteController(IWebsiteService websiteService)
        {
            _websiteService = websiteService;
        }

        [HttpGet]
        public async Task<List<Website>> Get()
        {
            List<Website> bookings = await _websiteService
                .GetAll(new CancellationToken()).ToListAsync();

            return bookings;
        }

        [HttpGet("{id}")]
        public async Task<ApiResponse<Website>> Get(int id)
        {
            ApiResponse<Website> response = new ApiResponse<Website>();
            Website website = await _websiteService
                .Get(id, new CancellationToken());

            if (website != null)
            {
                response.Data = website;
            }
            else
            {
                response.ErrorCode = Shared.Enums.ErrorCodes.NotFound;
            }

            return response;
        }

        [HttpPost]
        public async Task<ApiResponse<Website>> Create(Website model)
        {
            ApiResponse<Website> response = new ApiResponse<Website>();

            model = await _websiteService.Create(model);

            response.Data = model;

            if (response.Data == null)
            {
                response.ErrorCode = Shared.Enums.ErrorCodes.CreateFailed;
            }

            return response;
        }

        [HttpDelete("{id}")]
        public async Task<ApiResponse<bool>> Delete(int id)
        {
            ApiResponse<bool> response = new ApiResponse<bool>();

            try
            {
                Website entity = await _websiteService
                    .Get(id, new CancellationToken());

                bool deleted = await _websiteService.Delete(entity);

                if (deleted)
                {
                    response.Data = deleted;
                }
                else
                {
                    response.ErrorCode = Shared.Enums.ErrorCodes.DeleteFailed;
                }
            }
            catch (NotFoundException)
            {
                response.ErrorCode = Shared.Enums.ErrorCodes.NotFound;
            }

            return response;
        }
    }
}
