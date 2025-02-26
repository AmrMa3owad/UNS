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

    public class CraftController : ControllerBase
    {
        private readonly ICraftService _craftService;

        public CraftController(ICraftService craftService)
        {
            _craftService = craftService;
        }

        [HttpGet]
        public async Task<List<Craft>> Get()
        {
            List<Craft> bookings = await _craftService
                .GetAll(new CancellationToken()).ToListAsync();

            return bookings;
        }

        [HttpGet("{id}")]
        public async Task<ApiResponse<Craft>> Get(int id)
        {
            ApiResponse<Craft> response = new ApiResponse<Craft>();
            Craft craft = await _craftService
                .Get(id, new CancellationToken());

            if (craft != null)
            {
                response.Data = craft;
            }
            else
            {
                response.ErrorCode = Shared.Enums.ErrorCodes.NotFound;
            }

            return response;
        }

        [HttpPost]
        public async Task<ApiResponse<Craft>> Create(Craft model)
        {
            ApiResponse<Craft> response = new ApiResponse<Craft>();

            model = await _craftService.Create(model);

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
                Craft entity = await _craftService
                    .Get(id, new CancellationToken());

                bool deleted = await _craftService.Delete(entity);

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
