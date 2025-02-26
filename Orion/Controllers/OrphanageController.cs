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

    public class OrphanageController : ControllerBase
    {
        private readonly IOrphanageService _orphanageService;

        public OrphanageController(IOrphanageService orphanageService)
        {
            _orphanageService = orphanageService;
        }

        [HttpGet]
        public async Task<List<Orphanage>> GetO()
        {
            List<Orphanage> bookings = await _orphanageService
                .GetAll(new CancellationToken()).ToListAsync();

            return bookings;
        }

        [HttpGet("{id}")]
        public async Task<ApiResponse<Orphanage>> Get(int id)
        {
            ApiResponse<Orphanage> response = new ApiResponse<Orphanage>();
            Orphanage orphanage = await _orphanageService
                .Get(id, new CancellationToken());

            if (orphanage != null)
            {
                response.Data = orphanage;
            }
            else
            {
                response.ErrorCode = Shared.Enums.ErrorCodes.NotFound;
            }

            return response;
        }

        [HttpPost]
        public async Task<ApiResponse<Orphanage>> Create(Orphanage model)
        {
            ApiResponse<Orphanage> response = new ApiResponse<Orphanage>();

            model = await _orphanageService.Create(model);

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
                Orphanage entity = await _orphanageService
                    .Get(id, new CancellationToken());

                bool deleted = await _orphanageService.Delete(entity);

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
