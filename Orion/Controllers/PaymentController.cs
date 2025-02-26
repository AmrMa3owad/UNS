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

    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService _paymentService;

        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpGet]
        public async Task<List<Payment>> Get()
        {
            List<Payment> bookings = await _paymentService
                .GetAll(new CancellationToken()).ToListAsync();

            return bookings;
        }

        [HttpGet("{id}")]
        public async Task<ApiResponse<Payment>> Get(int id)
        {
            ApiResponse<Payment> response = new ApiResponse<Payment>();
            Payment payment = await _paymentService
                .Get(id, new CancellationToken());

            if (payment != null)
            {
                response.Data = payment;
            }
            else
            {
                response.ErrorCode = Shared.Enums.ErrorCodes.NotFound;
            }

            return response;
        }

        [HttpPost]
        public async Task<ApiResponse<Payment>> Create(Payment model)
        {
            ApiResponse<Payment> response = new ApiResponse<Payment>();

            model = await _paymentService.Create(model);

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
                Payment entity = await _paymentService
                    .Get(id, new CancellationToken());

                bool deleted = await _paymentService.Delete(entity);

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
