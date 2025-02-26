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

    public class PreCommunityController : ControllerBase
    {
        private readonly IPreCommunityService _preCommunityService;

        public PreCommunityController(IPreCommunityService preCommunityService)
        {
            _preCommunityService = preCommunityService;
        }

        [HttpGet]
        public async Task<List<PreCommunity>> Get()
        {
            List<PreCommunity> bookings = await _preCommunityService
                .GetAll(new CancellationToken()).ToListAsync();

            return bookings;
        }

        [HttpGet("{id}")]
        public async Task<ApiResponse<PreCommunity>> Get(int id)
        {
            ApiResponse<PreCommunity> response = new ApiResponse<PreCommunity>();
            PreCommunity preCommunity = await _preCommunityService
                .Get(id, new CancellationToken());

            if (preCommunity != null)
            {
                response.Data = preCommunity;
            }
            else
            {
                response.ErrorCode = Shared.Enums.ErrorCodes.NotFound;
            }

            return response;
        }

        [HttpPost]
        public async Task<ApiResponse<PreCommunity>> Create(PreCommunity model)
        {
            ApiResponse<PreCommunity> response = new ApiResponse<PreCommunity>();

            model = await _preCommunityService.Create(model);

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
                PreCommunity entity = await _preCommunityService
                    .Get(id, new CancellationToken());

                bool deleted = await _preCommunityService.Delete(entity);

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
