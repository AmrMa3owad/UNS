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

    public class OfficeWorkerController : ControllerBase
    {
        private readonly IOfficeWorkerService _officeWorkerService;

        public OfficeWorkerController(IOfficeWorkerService officeWorkerService)
        {
            _officeWorkerService = officeWorkerService;
        }

        [HttpGet]
        public async Task<List<OfficeWorker>> Get()
        {
            List<OfficeWorker> bookings = await _officeWorkerService
                .GetAll(new CancellationToken()).ToListAsync();

            return bookings;
        }

        [HttpGet("{id}")]
        public async Task<ApiResponse<OfficeWorker>> Get(int id)
        {
            ApiResponse<OfficeWorker> response = new ApiResponse<OfficeWorker>();
            OfficeWorker officeWorker = await _officeWorkerService
                .Get(id, new CancellationToken());

            if (officeWorker != null)
            {
                response.Data = officeWorker;
            }
            else
            {
                response.ErrorCode = Shared.Enums.ErrorCodes.NotFound;
            }

            return response;
        }

        [HttpPost]
        public async Task<ApiResponse<OfficeWorker>> Create(OfficeWorker model)
        {
            ApiResponse<OfficeWorker> response = new ApiResponse<OfficeWorker>();

            model = await _officeWorkerService.Create(model);

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
                OfficeWorker entity = await _officeWorkerService
                    .Get(id, new CancellationToken());

                bool deleted = await _officeWorkerService.Delete(entity);

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
