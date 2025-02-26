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

    public class CustomerAdvertisementController : ControllerBase
    {
        private readonly ICustomerAdvertisementService _customerAdvertisementService;

        public CustomerAdvertisementController(ICustomerAdvertisementService customerAdvertisementService)
        {
            _customerAdvertisementService = customerAdvertisementService;
        }

        [HttpGet]
        public async Task<List<CustomerAdvertisement>> Get()
        {
            List<CustomerAdvertisement> bookings = await _customerAdvertisementService
                .GetAll(new CancellationToken()).ToListAsync();

            return bookings;
        }

        [HttpGet("{id}")]
        public async Task<ApiResponse<CustomerAdvertisement>> Get(int id)
        {
            ApiResponse<CustomerAdvertisement> response = new ApiResponse<CustomerAdvertisement>();
            CustomerAdvertisement customerAdvertisement = await _customerAdvertisementService
                .Get(id, new CancellationToken());

            if (customerAdvertisement != null)
            {
                response.Data = customerAdvertisement;
            }
            else
            {
                response.ErrorCode = Shared.Enums.ErrorCodes.NotFound;
            }

            return response;
        }

        [HttpPost]
        public async Task<ApiResponse<CustomerAdvertisement>> Create(CustomerAdvertisement model)
        {
            ApiResponse<CustomerAdvertisement> response = new ApiResponse<CustomerAdvertisement>();

            model = await _customerAdvertisementService.Create(model);

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
                CustomerAdvertisement entity = await _customerAdvertisementService
                    .Get(id, new CancellationToken());

                bool deleted = await _customerAdvertisementService.Delete(entity);

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

