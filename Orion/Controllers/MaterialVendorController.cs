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

    public class MaterialVendorController : ControllerBase
    {
        private readonly IMaterialVendorService _materialVendorService;

        public MaterialVendorController(IMaterialVendorService materialVendorService)
        {
            _materialVendorService = materialVendorService;
        }

        [HttpGet]
        public async Task<List<MaterialVendor>> Get()
        {
            List<MaterialVendor> bookings = await _materialVendorService
                .GetAll(new CancellationToken()).ToListAsync();

            return bookings;
        }

        [HttpGet("{id}")]
        public async Task<ApiResponse<MaterialVendor>> Get(int id)
        {
            ApiResponse<MaterialVendor> response = new ApiResponse<MaterialVendor>();
            MaterialVendor materialVendor = await _materialVendorService
                .Get(id, new CancellationToken());

            if (materialVendor != null)
            {
                response.Data = materialVendor;
            }
            else
            {
                response.ErrorCode = Shared.Enums.ErrorCodes.NotFound;
            }

            return response;
        }

        [HttpPost]
        public async Task<ApiResponse<MaterialVendor>> Create(MaterialVendor model)
        {
            ApiResponse<MaterialVendor> response = new ApiResponse<MaterialVendor>();

            model = await _materialVendorService.Create(model);

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
                MaterialVendor entity = await _materialVendorService
                    .Get(id, new CancellationToken());

                bool deleted = await _materialVendorService.Delete(entity);

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
