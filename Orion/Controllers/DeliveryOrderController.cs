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

    public class DeliveryOrderController : ControllerBase
    {
        private readonly IDeliveryOrderService _deliveryOrderService;

        public DeliveryOrderController(IDeliveryOrderService deliveryOrderService)
        {
            _deliveryOrderService = deliveryOrderService;
        }

        [HttpGet]
        public async Task<List<DeliveryOrder>> Get()
        {
            List<DeliveryOrder> bookings = await _deliveryOrderService
                .GetAll(new CancellationToken()).ToListAsync();

            return bookings;
        }

        [HttpGet("{id}")]
        public async Task<ApiResponse<DeliveryOrder>> Get(int id)
        {
            ApiResponse<DeliveryOrder> response = new ApiResponse<DeliveryOrder>();
            DeliveryOrder deliveryOrder = await _deliveryOrderService
                .Get(id, new CancellationToken());

            if (deliveryOrder != null)
            {
                response.Data = deliveryOrder;
            }
            else
            {
                response.ErrorCode = Shared.Enums.ErrorCodes.NotFound;
            }

            return response;
        }

        [HttpPost]
        public async Task<ApiResponse<DeliveryOrder>> Create(DeliveryOrder model)
        {
            ApiResponse<DeliveryOrder> response = new ApiResponse<DeliveryOrder>();

            model = await _deliveryOrderService.Create(model);

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
                DeliveryOrder entity = await _deliveryOrderService
                    .Get(id, new CancellationToken());

                bool deleted = await _deliveryOrderService.Delete(entity);

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
