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

    public class BoothController : ControllerBase
    {
        private readonly IBoothService _boothService;

        public BoothController(IBoothService boothService)
        {
            _boothService = boothService;
        }

        [HttpGet]
        public async Task<List<Booth>> Get()
        {
            List<Booth> bookings = await _boothService
                .GetAll(new CancellationToken()).ToListAsync();

            return bookings;
        }

        [HttpGet("{id}")]
        public async Task<ApiResponse<Booth>> Get(int id)
        {
            ApiResponse<Booth> response = new ApiResponse<Booth>();
            Booth booth = await _boothService
                .Get(id, new CancellationToken());

            if (booth != null)
            {
                response.Data = booth;
            }
            else
            {
                response.ErrorCode = Shared.Enums.ErrorCodes.NotFound;
            }

            return response;
        }

        [HttpPost]
        public async Task<ApiResponse<Booth>> Create(Booth model)
        {
            ApiResponse<Booth> response = new ApiResponse<Booth>();

            model = await _boothService.Create(model);

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
                Booth entity = await _boothService
                    .Get(id, new CancellationToken());

                bool deleted = await _boothService.Delete(entity);

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
