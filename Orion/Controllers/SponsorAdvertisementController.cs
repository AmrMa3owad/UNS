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

    public class SponsorAdvertisementController : ControllerBase
    {
        private readonly ISponsorAdvertisementService _sponsorAdvertisementService;

        public SponsorAdvertisementController(ISponsorAdvertisementService sponsorAdvertisementService)
        {
            _sponsorAdvertisementService = sponsorAdvertisementService;
        }

        [HttpGet]
        public async Task<List<SponsorAdvertisement>> Get()
        {
            List<SponsorAdvertisement> bookings = await _sponsorAdvertisementService
                .GetAll(new CancellationToken()).ToListAsync();

            return bookings;
        }

        [HttpGet("{id}")]
        public async Task<ApiResponse<SponsorAdvertisement>> Get(int id)
        {
            ApiResponse<SponsorAdvertisement> response = new ApiResponse<SponsorAdvertisement>();
            SponsorAdvertisement sponsorAdvertisement = await _sponsorAdvertisementService
                .Get(id, new CancellationToken());

            if (sponsorAdvertisement != null)
            {
                response.Data = sponsorAdvertisement;
            }
            else
            {
                response.ErrorCode = Shared.Enums.ErrorCodes.NotFound;
            }

            return response;
        }

        [HttpPost]
        public async Task<ApiResponse<SponsorAdvertisement>> Create(SponsorAdvertisement model)
        {
            ApiResponse<SponsorAdvertisement> response = new ApiResponse<SponsorAdvertisement>();

            model = await _sponsorAdvertisementService.Create(model);

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
                SponsorAdvertisement entity = await _sponsorAdvertisementService
                    .Get(id, new CancellationToken());

                bool deleted = await _sponsorAdvertisementService.Delete(entity);

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
