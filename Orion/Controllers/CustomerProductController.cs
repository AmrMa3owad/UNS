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

    public class CustomerProductController : ControllerBase
    {
        private readonly ICustomerProductService _customerProductService;

        public CustomerProductController(ICustomerProductService customerProductService)
        {
            _customerProductService = customerProductService;
        }

        [HttpGet]
        public async Task<List<CustomerProduct>> Get()
        {
            List<CustomerProduct> bookings = await _customerProductService
                .GetAll(new CancellationToken()).ToListAsync();

            return bookings;
        }

        [HttpGet("{id}")]
        public async Task<ApiResponse<CustomerProduct>> Get(int id)
        {
            ApiResponse<CustomerProduct> response = new ApiResponse<CustomerProduct>();
            CustomerProduct customerProduct = await _customerProductService
                .Get(id, new CancellationToken());

            if (customerProduct != null)
            {
                response.Data = customerProduct;
            }
            else
            {
                response.ErrorCode = Shared.Enums.ErrorCodes.NotFound;
            }

            return response;
        }

        [HttpPost]
        public async Task<ApiResponse<CustomerProduct>> Create(CustomerProduct model)
        {
            ApiResponse<CustomerProduct> response = new ApiResponse<CustomerProduct>();

            model = await _customerProductService.Create(model);

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
                CustomerProduct entity = await _customerProductService
                    .Get(id, new CancellationToken());

                bool deleted = await _customerProductService.Delete(entity);

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
