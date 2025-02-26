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

    public class BoothOrderController : ControllerBase
    {
        private readonly IBoothOrderService _boothOrderService;

        public BoothOrderController(IBoothOrderService boothOrderService)
        {
            _boothOrderService = boothOrderService;
        }

        [HttpGet]
        public async Task<List<BoothOrder>> Get()
        {
            List<BoothOrder> bookings = await _boothOrderService
                .GetAll(new CancellationToken()).ToListAsync();

            return bookings;
        }

        [HttpGet("{id}")]
        public async Task<ApiResponse<BoothOrder>> Get(int id)
        {
            ApiResponse<BoothOrder> response = new ApiResponse<BoothOrder>();
            BoothOrder boothOrder = await _boothOrderService
                .Get(id, new CancellationToken());

            if (boothOrder != null)
            {
                response.Data = boothOrder;
            }
            else
            {
                response.ErrorCode = Shared.Enums.ErrorCodes.NotFound;
            }

            return response;
        }

        [HttpPost]
        public async Task<ApiResponse<BoothOrder>> Create(BoothOrder model)
        {
            ApiResponse<BoothOrder> response = new ApiResponse<BoothOrder>();

            model = await _boothOrderService.Create(model);

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
                BoothOrder entity = await _boothOrderService
                    .Get(id, new CancellationToken());

                bool deleted = await _boothOrderService.Delete(entity);

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
